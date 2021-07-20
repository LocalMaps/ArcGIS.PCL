namespace ArcGIS.ServiceModel
{
    using Common;
    using Operation;
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ArcGIS Online gateway
    /// </summary>
    public class ArcGISOnlineGateway : PortalGatewayBase
    {
        /// <summary>
        /// Create an ArcGIS Online gateway to access resources
        /// </summary>
        /// <param name="serializer">Used to (de)serialize requests and responses</param>
        /// <param name="tokenProvider">Provide access to a token for secure resources</param>
        /// <param name="httpClientFunc">Function that resolves to a HTTP client used to send requests</param>
        public ArcGISOnlineGateway(ISerializer serializer = null, ITokenProvider tokenProvider = null, Func<HttpClient> httpClientFunc = null)
            : this(PortalGatewayBase.AGOPortalUrl, serializer, tokenProvider, httpClientFunc)
        { }

        public ArcGISOnlineGateway(string rootUrl, ISerializer serializer = null, ITokenProvider tokenProvider = null, Func<HttpClient> httpClientFunc = null)
            : base(rootUrl, serializer, tokenProvider, httpClientFunc)
        { }

        protected override IEndpoint GeometryServiceEndpoint
        {
            get { return GeometryServiceIEndpoint ?? (GeometryServiceIEndpoint = (IEndpoint)GeometryServerUrl.AsAbsoluteEndpoint()); }
        }

        /// <summary>
        /// Search for feature services on ArcGIS Online / Portal for the user specified
        /// </summary>
        /// <param name="ct">Optional cancellation token</param>
        /// <param name="username">User whose content to search for, if not specified then the user
        /// from the <see cref="ITokenProvider" />  for this gateway will be used.</param>
        /// <returns>The discovered hosted feature services</returns>
        public Task<SearchHostedFeatureServicesResponse> DescribeSite(CancellationToken ct = default(CancellationToken), string username = "", string[] searchTags = null )
        {
            //In order to find all the feature layers in the org, need to get the organisation id.

            var portal = DescribeSelf(ct).Result;
            var orgId = portal.id;

            if (string.IsNullOrWhiteSpace(username) && TokenProvider != null)
                username = TokenProvider.UserName;

            var tags = "";
            if (searchTags != null) {
                foreach (var item in searchTags)
                {
                    tags += string.Format(" tags:\"{0}\" ", item);
                }
            }

            var search = string.IsNullOrWhiteSpace(orgId)
                ? new SearchHostedFeatureServices() { StartIndex = 0, NumberToReturn = 200 }
                : new SearchHostedFeatureServices(orgId, username,tags) { StartIndex = 0, NumberToReturn = 200 };
            return Get<SearchHostedFeatureServicesResponse, SearchHostedFeatureServices>(search, ct);
        }

        /// <summary>
        /// Returns an item object from a portal
        /// </summary>
        /// <param name="itemId">The item id to get</param>
        /// <param name="ct">Optional cancellation token to cancel pending request</param>
        /// <returns></returns>
        public Task<SearchItemResponse> GetItem(string itemId, CancellationToken ct = default(CancellationToken))
        {
            return Get<SearchItemResponse,SearchItem>(new SearchItem(itemId), ct);
        }

        /// <summary>
        /// Returns an item object from a portal
        /// </summary>
        /// <param name="itemId">The item id to get</param>
        /// <param name="ct">Optional cancellation token to cancel pending request</param>
        /// <returns></returns>
        public Task<SearchItemResponse> GetGeocoders(CancellationToken ct = default(CancellationToken))
        {
            var portal = DescribeSelf(ct).Result;
            var orgId = portal.id;
            return Get<SearchItemResponse, SearchGeocoders>(new SearchGeocoders(orgId), ct);
        }



    }
}
