using ArcGIS.ServiceModel.Common;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace ArcGIS.ServiceModel.Operation
{
    [DataContract]
    public class QueryRelatedRecords : ArcGISServerOperation
    {
        public QueryRelatedRecords(ArcGISServerEndpoint endpoint)
        {
            Guard.AgainstNullArgument("endpoint", endpoint);
            Endpoint = new ArcGISServerEndpoint(endpoint.RelativeUrl.Trim('/') + "/" + Operations.QueryRelatedRecords);
            DefinitionExpression = "1=1";
        }

        /// <summary>
        /// The definition expression to be applied to the related table or layer. From the list 
        /// of objectIds, only those records that conform to this expression are queried for related records.
        /// </summary>
        [DataMember(Name = "definitionExpression")]
        public string DefinitionExpression { get; set; }

        /// <summary>
        ///  The object IDs of this layer/table to be queried.
        /// </summary>
        [IgnoreDataMember]
        public List<long> ObjectIds { get; set; }

        /// <summary>
        /// The list of object Ids to be queried. This list is a comma delimited list of field names.
        /// </summary>
        [DataMember(Name = "objectIds")]
        public string ObjectIdsValue { get { return ObjectIds == null || !ObjectIds.Any() ? null : string.Join(",", ObjectIds); } }

        /// <summary>
        /// The ID of the relationship to be queried. The relationships in which this layer or table 
        /// participates are included in the Feature Service Layer resource response. Records in tables 
        /// or layers corresponding to the related table or layer of the relationship are queried.
        /// </summary>
        [DataMember(Name = "relationshipId")]
        public int RelationshipID { get; set; }

        /// <summary>
        ///  The names of the fields to search.
        /// </summary>
        [IgnoreDataMember]
        public List<string> OutFields { get; set; }

        /// <summary>
        /// The list of fields to be included in the returned resultset. This list is a comma delimited list of field names.
        /// If you specify the shape field in the list of return fields, it is ignored. To request geometry, set returnGeometry to true.
        /// </summary>
        /// <remarks>Default is '*' (all fields)</remarks>
        [DataMember(Name = "outFields")]
        public string OutFieldsValue { get { return OutFields == null || !OutFields.Any() ? "*" : string.Join(",", OutFields); } }

        /// <summary>
        ///  The names of the fields to order by.
        /// </summary>
        [IgnoreDataMember]
        public List<string> OrderBy { get; set; }

        /// <summary>
        /// One or more field names on which the features/records need to be ordered.
        /// Use ASC or DESC for ascending or descending, respectively, following every field to control the ordering.
        /// Defaults to ASC (ascending order) if <ORDER> is unspecified.
        /// </summary>
        /// <remarks>Default is '*' (all fields)</remarks>
        [DataMember(Name = "orderByFields")]
        public string OrderByValue { get { return OrderBy == null || !OrderBy.Any() ? null : string.Join(",", OrderBy); } }

        /// <summary>
        /// If true, the resultset includes the geometry associated with each result.
        /// </summary>
        /// <remarks>Default is true</remarks>
        [DataMember(Name = "returnGeometry")]
        public bool ReturnGeometry { get; set; }

        /// <summary>
        /// This option can be used to specify the maximum allowable offset to be used for generalizing geometries returned by the query operation.
        /// </summary>
        [DataMember(Name = "maxAllowableOffset")]
        public int? MaxAllowableOffset { get; set; }

        /// <summary>
        /// This option can be used to specify the number of decimal places in the response geometries returned by the query operation.
        /// This applies to X and Y values only (not m or z values).
        /// </summary>
        [DataMember(Name = "geometryPrecision")]
        public int? GeometryPrecision { get; set; }

        /// <summary>
        /// The spatial reference of the returned geometry.
        /// If not specified, the geometry is returned in the spatial reference of the input.
        /// </summary>
        [DataMember(Name = "outSR")]
        public SpatialReference OutputSpatialReference { get; set; }

        /// <summary>
        /// This option was added at 10.3.
        /// Description: This option can be used for fetching query results by skipping the specified number of records and
        /// starts from the next record (i.e., resultOffset + 1th). The default is 0.
        /// This parameter only applies if supportsPagination is true.
        /// You can use this option to fetch records that are beyond maxRecordCount.
        /// For example, if maxRecordCountis 1000, you can get the next 100 records by setting resultOffset=1000
        /// and resultRecordCount = 100, query results can return the results in the range of 1001 to 1100.
        /// </summary>
        [DataMember(Name = "resultOffset")]
        public int? ResultOffset { get; set; }

        /// <summary>
        /// This option was added at 10.3.
        /// Description: This option can be used for fetching query results up to the resultRecordCount specified.
        /// When resultOffset is specified but this parameter is not, map service defaults it to maxRecordCount.
        /// The maximum value for this parameter is the value of the layer's maxRecordCount property.
        /// This parameter only applies if supportsPagination is true.
        /// Example: resultRecordCount=10 to fetch up to 10 records
        /// </summary>
        [DataMember(Name = "resultRecordCount")]
        public int? ResultRecordCount { get; set; }

        /// <summary>
        /// If true, Z values will be included in the results if the features have Z values. Otherwise, Z values are not returned.
        /// </summary>
        /// <remarks>Default is false. This parameter only applies if returnGeometry=true.</remarks>
        [DataMember(Name = "returnZ")]
        public bool ReturnZ { get; set; }

        /// <summary>
        /// If true, M values will be included in the results if the features have M values. Otherwise, M values are not returned.
        /// </summary>
        /// <remarks>Default is false. This parameter only applies if returnGeometry=true.</remarks>
        [DataMember(Name = "returnM")]
        public bool ReturnM { get; set; }

        [DataContract]
        public class QueryRelatedRecordsResponse<T> : PortalResponse where T : IGeometry
        {
            public QueryRelatedRecordsResponse()
            {
                // FieldAliases = new Dictionary<string, string>();
            }

            [DataMember(Name = "geometryType")]
            public string GeometryTypeString { get; set; }

            [IgnoreDataMember]
            public System.Type GeometryType { get { return GeometryTypes.ToTypeMap[GeometryTypeString](); } }

            [DataMember(Name = "spatialReference")]
            public SpatialReference SpatialReference { get; set; }

            [DataMember(Name = "hasZ")]
            public bool? HasZ { get; set; }

            [DataMember(Name = "hasM")]
            public bool? HasM { get; set; }

            [DataMember(Name = "fields")]
            public IEnumerable<Field> Fields { get; set; }

            [DataMember(Name = "relatedRecordGroups")]
            public IEnumerable<RelatedRecordGroup<T>> RelatedRecordGroups { get; set; }

            //[DataMember(Name = "features")]
            //public IEnumerable<Feature<T>> Features { get; set; }

            // todo - review
            //[DataMember(Name = "fieldAliases")]
            //public Dictionary<string, string> FieldAliases { get; set; }

            [DataMember(Name = "exceededTransferLimit")]
            public bool? ExceededTransferLimit { get; set; }

        }

        /// <summary>
        /// Perform a query that only returns a count of the results
        /// </summary>
        [DataContract]
        public class QueryRelatedRecordsForCount : QueryRelatedRecords
        {
            public QueryRelatedRecordsForCount(ArcGISServerEndpoint endpoint)
                : base(endpoint)
            {
                ReturnGeometry = false;
            }

            [DataMember(Name = "returnCountOnly")]
            public bool ReturnCountOnly { get { return true; } }
        }

        [DataContract]
        public class QueryRelatedRecordsForCountResponse : PortalResponse
        {
            [DataMember(Name = "count")]
            public int NumberOfResults { get; set; }
        }

        [DataContract]
        public class RelatedRecordGroup<T> where T : IGeometry
        {
            [DataMember(Name = "objectId")]
            public long ObjectID {  get; set; }

            [DataMember(Name = "relatedRecords")]
            public IEnumerable<Feature<T>> RelatedRecords { get; set; }
            // public IEnumerable<RelatedRecord> RelatedRecords { get; set; }
        }

        //[DataContract]
        //public class RelatedRecord
        //{

        //}
    }
}