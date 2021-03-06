using MongoDB.Bson.Serialization.Attributes;

namespace video_editing_api.Model.Collection
{
    public class HighlightVideo
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string MatchId { get; set; }
        public string MatchInfo { get; set; }
        public string PublicId { get; set; }
        public string Url { get; set; }
    }
}
