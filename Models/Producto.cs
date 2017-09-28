using MongoDB.Bson;
using Newtonsoft.Json.Bson;

namespace WebApiMongo.Models
{
    public class Producto
    {
        public ObjectId id { get; set; };
    }
}