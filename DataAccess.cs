using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Drawing;

namespace MotionDetection
{
    //db.record.find({ "Time":{$gt: "2016-03-08 00:00:00", $lt: "2016-03-08 01:00:00"} })
    //db.record.insert({ "Camera":"Camera1","Time":"2016-03-08 09:12:12","MotionCout":1234})
    class DataAccess
    {
        protected static IMongoClient client;
        protected static IMongoDatabase database;

        public DataAccess()
        {

        }

        //insert function
        static public async Task<bool> Insert(BsonDocument document)
        {
            bool result = false;
            client = new MongoClient();
            database = client.GetDatabase("firekam");
            var collection = database.GetCollection<BsonDocument>("record");
            await collection.InsertOneAsync(document);

            return result;
        }

        //find by camera
        static public async Task<string> FindByCamera(string camera)
        {
            client = new MongoClient();
            database = client.GetDatabase("firekam");
            var collection = database.GetCollection<BsonDocument>("record"); 
            var filter = Builders<BsonDocument>.Filter.Eq("Camera", "kevin");
            var result = await collection.Find(filter).ToListAsync();
            
            return result.First().ToString();
        }

        //find by time
        static public async Task<List<BsonDocument>> FindByTime(string minTime, string maxTime, string source)
        {
            client = new MongoClient();
            database = client.GetDatabase("firekam");
            var collection = database.GetCollection<BsonDocument>("record");
            FilterDefinition<BsonDocument> filter;
            if (source == "All")
            {
                filter = Builders<BsonDocument>.Filter.Gt("Time", minTime) & Builders<BsonDocument>.Filter.Lt("Time", maxTime);
            }
            else
            {
                filter = Builders<BsonDocument>.Filter.Gt("Time", minTime) & Builders<BsonDocument>.Filter.Lt("Time", maxTime) & Builders<BsonDocument>.Filter.Eq("Source", source);
            }
            //var resultFirst = await collection.Find(filter).ToListAsync();
            var aggregate = collection.Aggregate().Match(filter).Group(new BsonDocument { { "_id", 0 }, { "MotionCount", new BsonDocument("$sum", "$MotionCout") } });
            var results = await aggregate.ToListAsync();
            if (results.Count == 0)
            {
                results = null;
                return results;
            }
            return results;
        }

        //find by motion points
        static public async Task<List<Point>> FindMotionPoints(string minTime, string maxTime, string source)
        {
            List<Point> pointsList = new List<Point>();
            client = new MongoClient();
            database = client.GetDatabase("firekam");
            var collection = database.GetCollection<BsonDocument>("record");
            FilterDefinition<BsonDocument> filter = null;
            if (source == "All")
            {
                filter = Builders<BsonDocument>.Filter.Gt("Time", minTime) & Builders<BsonDocument>.Filter.Lt("Time", maxTime);
            }
            else
            {
                filter = Builders<BsonDocument>.Filter.Gt("Time", minTime) & Builders<BsonDocument>.Filter.Lt("Time", maxTime) & Builders<BsonDocument>.Filter.Eq("Source", source);
            }
            var results = await collection.Find(filter).ToListAsync();

            foreach (var result in results)
            {
                //check if areax exist, can be deleted after
                BsonElement a;
                result.TryGetElement("AreaX", out a);
                if (a.Value!=null)
                {
                    Point temp = new Point(int.Parse(result.GetElement("AreaX").Value.ToString()), int.Parse(result.GetElement("AreaY").Value.ToString()));
                    pointsList.Add(temp);
                } 
            }

            if(results.Count == 0)
            {
                pointsList = null;
                return pointsList;
            }
            return pointsList;
        }

        //find by time and areacode
        static public async Task<List<BsonDocument>> FindByTimeAndArea(string minTime, string maxTime, int area, string source)
        {
            client = new MongoClient();
            database = client.GetDatabase("firekam");
            var collection = database.GetCollection<BsonDocument>("record");
            FilterDefinition<BsonDocument> filter = null;
            if (source == "All")
            {
                filter = Builders<BsonDocument>.Filter.Gt("Time", minTime) & Builders<BsonDocument>.Filter.Lt("Time", maxTime) & Builders<BsonDocument>.Filter.Eq("Area", area.ToString());
            }
            else
            {
                filter = Builders<BsonDocument>.Filter.Gt("Time", minTime) & Builders<BsonDocument>.Filter.Lt("Time", maxTime) & Builders<BsonDocument>.Filter.Eq("Area", area.ToString()) & Builders<BsonDocument>.Filter.Eq("Source", source);
            }
            var resultFirst = await collection.Find(filter).ToListAsync();
            var aggregate = collection.Aggregate().Match(filter).Group(new BsonDocument { { "_id", 0 }, { "MotionCount", new BsonDocument("$sum", "$MotionCout") } });
            var results = await aggregate.ToListAsync();
            if (results.Count == 0)
            {
                results = null;
                return results;
            }
            //return results[0].GetElement("MotionCount").Value.ToString();
            return results;
        }

        static public async Task<List<string>> FindSourceDistinct()
        {

            client = new MongoClient();
            database = client.GetDatabase("firekam");
            var collection = database.GetCollection<BsonDocument>("record");
            var filter = new BsonDocument();
            var distinctValue =  await collection.DistinctAsync<string>("Source", filter);
            return distinctValue.ToList();
        }
    }
}
