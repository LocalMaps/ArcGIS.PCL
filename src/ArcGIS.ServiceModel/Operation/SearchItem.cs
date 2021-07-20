using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ArcGIS.ServiceModel.Operation
{
    public class SearchItem:SearchArcGISOnline
    {
        public SearchItem(string itemId)
          : base(string.Format("id:{0}", itemId))
        { }

    }

    public class SearchItemResponse : PortalResponse
    {
        [DataMember(Name = "results")]
        public ItemResponse[] Results { get; set; }
    }

        public class ItemResponse
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string owner { get; set; }
        [DataMember]
        public long created { get; set; }
        [DataMember]
        public long modified { get; set; }
        [DataMember]
        public object name { get; set; }
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public string type { get; set; }
        [DataMember]
        public List<string> typeKeywords { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public List<string> tags { get; set; }
        [DataMember]
        public string snippet { get; set; }
        [DataMember]
        public string thumbnail { get; set; }
        [DataMember]
        public List<List<double>> extent { get; set; }
        [DataMember]
        public object spatialReference { get; set; }
        [DataMember]
        public List<string> categories { get; set; }
        [DataMember]
        public object accessInformation { get; set; }
        [DataMember]
        public string licenseInfo { get; set; }
        [DataMember]
        public string culture { get; set; }
        [DataMember]
        public string url { get; set; }
        [DataMember]
        public object proxyFilter { get; set; }
        [DataMember]
        public string access { get; set; }
        [DataMember]
        public int size { get; set; }
        [DataMember]
        public object properties { get; set; }
        [DataMember]
        public List<object> appCategories { get; set; }
        [DataMember]
        public List<object> industries { get; set; }
        [DataMember]
        public List<object> languages { get; set; }
        [DataMember]
        public object largeThumbnail { get; set; }
        [DataMember]
        public object banner { get; set; }
        [DataMember]
        public List<object> screenshots { get; set; }
        [DataMember]
        public bool listed { get; set; }
        [DataMember]
        public string ownerFolder { get; set; }
        [DataMember]
        public bool @protected { get; set; }
        [DataMember]
        public bool commentsEnabled { get; set; }
        [DataMember]
        public int numComments { get; set; }
        [DataMember]
        public int numRatings { get; set; }
        [DataMember]
        public int avgRating { get; set; }
        [DataMember]
        public int numViews { get; set; }
        [DataMember]
        public string itemControl { get; set; }
        [DataMember]
        public int scoreCompleteness { get; set; }
    }
}
