using ArcGIS.ServiceModel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ArcGIS.ServiceModel.Operation
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class Self: ArcGISServerOperation
    {
        public Self(ArcGISOnlineEndpoint endpoint)
        {
            Guard.AgainstNullArgument("endpoint", endpoint);
            Endpoint = endpoint;
        }
    }



    [DataContract]
    public class DefaultBasemap
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public List<BaseMapLayer> baseMapLayers { get; set; }
        [DataMember]
        public List<object> operationalLayers { get; set; }
    }

    [DataContract]
    public class DefaultExtent
    {
        [DataMember]
        public double xmin { get; set; }
        [DataMember]
        public double ymin { get; set; }
        [DataMember]
        public double xmax { get; set; }
        [DataMember]
        public double ymax { get; set; }
        [DataMember]
        public SpatialReference spatialReference { get; set; }
    }

    [DataContract]
    public class BaseMapLayer
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string layerType { get; set; }
        [DataMember]
        public string url { get; set; }
        [DataMember]
        public bool visibility { get; set; }
        [DataMember]
        public double opacity { get; set; }
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public string type { get; set; }
        [DataMember]
        public string styleUrl { get; set; }
    }

    [DataContract]
    public class DefaultVectorBasemap
    {
        [DataMember]
        public List<BaseMapLayer> baseMapLayers { get; set; }
        [DataMember]
        public string title { get; set; }
    }

    [DataContract]
    public class FeaturedGroup
    {
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public string owner { get; set; }
    }




    [DataContract]
    public class AsyncClosestFacility
    {
        [DataMember]
        public string url { get; set; }
        [DataMember]
        public string defaultTravelMode { get; set; }
    }

    [DataContract]
    public class AsyncLocationAllocation
    {
        [DataMember]
        public string url { get; set; }
        [DataMember]
        public string defaultTravelMode { get; set; }
    }

    [DataContract]
    public class AsyncODCostMatrix
    {
        [DataMember]
        public string url { get; set; }
        [DataMember]
        public string defaultTravelMode { get; set; }
    }

    [DataContract]
    public class AsyncRoute
    {
        [DataMember]
        public string url { get; set; }
        [DataMember]
        public string defaultTravelMode { get; set; }
    }

    [DataContract]
    public class AsyncServiceArea
    {
        [DataMember]
        public string url { get; set; }
        [DataMember]
        public string defaultTravelMode { get; set; }
    }

    [DataContract]
    public class AsyncVRP
    {
        [DataMember]
        public string url { get; set; }
        [DataMember]
        public string defaultTravelMode { get; set; }
    }

    [DataContract]
    public class ClosestFacility
    {
        [DataMember]
        public string url { get; set; }
        [DataMember]
        public string defaultTravelMode { get; set; }
    }

    [DataContract]
    public class DefaultElevationLayer
    {
        [DataMember]
        public string url { get; set; }
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string layerType { get; set; }
    }

    [DataContract]
    public class Elevation
    {
        [DataMember]
        public string url { get; set; }
    }

    [DataContract]
    public class ElevationSync
    {
        [DataMember]
        public string url { get; set; }
    }

    [DataContract]
    public class Geocode
    {
        [DataMember]
        public string url { get; set; }
        [DataMember]
        public string northLat { get; set; }
        [DataMember]
        public string southLat { get; set; }
        [DataMember]
        public string eastLon { get; set; }
        [DataMember]
        public string westLon { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public bool suggest { get; set; }
        [DataMember]
        public bool placefinding { get; set; }
        [DataMember]
        public bool batch { get; set; }
        
    }

    [DataContract]
    public class Geometry
    {
        [DataMember]
        public string url { get; set; }
    }

    [DataContract]
    public class Hydrology
    {
        [DataMember]
        public string url { get; set; }
    }

    [DataContract]
    public class OrthomappingElevation
    {
        [DataMember]
        public string url { get; set; }
    }

    [DataContract]
    public class Packaging
    {
        [DataMember]
        public string url { get; set; }
    }

    [DataContract]
    public class PrintTask
    {
        [DataMember]
        public string url { get; set; }
    }

    [DataContract]
    public class Route
    {
        [DataMember]
        public string url { get; set; }
        [DataMember]
        public string defaultTravelMode { get; set; }
    }

    [DataContract]
    public class RoutingUtilities
    {
        [DataMember]
        public string url { get; set; }
    }

    [DataContract]
    public class ServiceArea
    {
        [DataMember]
        public string url { get; set; }
        [DataMember]
        public string defaultTravelMode { get; set; }
    }

    [DataContract]
    public class SyncVRP
    {
        [DataMember]
        public string url { get; set; }
        [DataMember]
        public string defaultTravelMode { get; set; }
    }

    [DataContract]
    public class Traffic
    {
        [DataMember]
        public string url { get; set; }
    }

    [DataContract]
    public class Analysis
            {
        [DataMember]
        public string url { get; set; }
    }

    [DataContract]
    public class Geoenrichment
    {
        [DataMember]
        public string url { get; set; }
    }

    [DataContract]
    public class AsyncGeocode
    {
        [DataMember]
        public string url { get; set; }
    }

    [DataContract]
    public class HelperServices
    {
        [DataMember]
        public AsyncClosestFacility asyncClosestFacility { get; set; }
        [DataMember]
        public AsyncLocationAllocation asyncLocationAllocation { get; set; }
        [DataMember]
        public AsyncODCostMatrix asyncODCostMatrix { get; set; }
        [DataMember]
        public AsyncRoute asyncRoute { get; set; }
        [DataMember]
        public AsyncServiceArea asyncServiceArea { get; set; }
        [DataMember]
        public AsyncVRP asyncVRP { get; set; }
        [DataMember]
        public ClosestFacility closestFacility { get; set; }
        [DataMember]
        public List<DefaultElevationLayer> defaultElevationLayers { get; set; }
        [DataMember]
        public Elevation elevation { get; set; }
        [DataMember]
        public ElevationSync elevationSync { get; set; }
        [DataMember]
        public List<Geocode> geocode { get; set; }
        [DataMember]
        public Geometry geometry { get; set; }
        [DataMember]
        public Hydrology hydrology { get; set; }
        [DataMember]
        public OrthomappingElevation orthomappingElevation { get; set; }
        [DataMember]
        public Packaging packaging { get; set; }
        [DataMember]
        public PrintTask printTask { get; set; }
        [DataMember]
        public Route route { get; set; }
        [DataMember]
        public RoutingUtilities routingUtilities { get; set; }
        [DataMember]
        public ServiceArea serviceArea { get; set; }
        [DataMember]
        public SyncVRP syncVRP { get; set; }
        [DataMember]
        public Traffic traffic { get; set; }
        [DataMember]
        public Analysis analysis { get; set; }
        [DataMember]
        public Geoenrichment geoenrichment { get; set; }
        [DataMember]
        public AsyncGeocode asyncGeocode { get; set; }
    }

    [DataContract]
    public class Links
    {
    }

    [DataContract]
    public class Migrations
    {
        [DataMember]
        public bool siteToItems { get; set; }
    }

    [DataContract]
    public class Settings
    {
        [DataMember]
        public string groupId { get; set; }
        [DataMember]
        public Migrations migrations { get; set; }
        [DataMember]
        public string appVersion { get; set; }
    }

    [DataContract]
    public class OpenData
    {
        [DataMember]
        public bool enabled { get; set; }
        [DataMember]
        public Settings settings { get; set; }
    }

    [DataContract]
    public class Header
    {
        [DataMember]
        public string background { get; set; }
        [DataMember]
        public string text { get; set; }
    }

    [DataContract]
    public class Body
    {
        [DataMember]
        public string background { get; set; }
        [DataMember]
        public string text { get; set; }
        [DataMember]
        public string link { get; set; }
    }

    [DataContract]
    public class Button
    {
        [DataMember]
        public string background { get; set; }
        [DataMember]
        public string text { get; set; }
    }

    [DataContract]
    public class Logo

    {
        [DataMember]
        public string small { get; set; }
    }

    [DataContract]
    public class SharedTheme
    {
        [DataMember]
        public Header header { get; set; }
        [DataMember]
        public Body body { get; set; }
        [DataMember]
        public Button button { get; set; }
        [DataMember]
        public Logo logo { get; set; }
    }

    [DataContract]
    public class PortalProperties
    {
        [DataMember]
        public Links links { get; set; }
        [DataMember]
        public bool showSocialMediaLinks { get; set; }
        [DataMember]
        public OpenData openData { get; set; }
        [DataMember]
        public SharedTheme sharedTheme { get; set; }
    }

    [DataContract]
    public class RotatorPanel
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string innerHTML { get; set; }
    }

    [DataContract]
    public class SelfResponse:PortalResponse
    {
        [DataMember]
        public string access { get; set; }
        [DataMember]
        public bool allSSL { get; set; }
        [DataMember]
        public List<string> allowedRedirectUris { get; set; }
        [DataMember]
        public string analysisLayersGroupQuery { get; set; }
        [DataMember]
        public List<string> authorizedCrossOriginDomains { get; set; }
        [DataMember]
        public string backgroundImage { get; set; }
        [DataMember]
        public string basemapGalleryGroupQuery { get; set; }
        [DataMember]
        public bool canShareBingPublic { get; set; }
        [DataMember]
        public string colorSetsGroupQuery { get; set; }
        [DataMember]
        public bool commentsEnabled { get; set; }
        [DataMember]
        public string contentCategorySetsGroupQuery { get; set; }
        [DataMember]
        public string culture { get; set; }
        [DataMember]
        public string customBaseUrl { get; set; }
        [DataMember]
        public DefaultBasemap defaultBasemap { get; set; }
        [DataMember]
        public DefaultExtent defaultExtent { get; set; }
        [DataMember]
        public DefaultVectorBasemap defaultVectorBasemap { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public bool eueiEnabled { get; set; }
        [DataMember]
        public List<FeaturedGroup> featuredGroups { get; set; }
        [DataMember]
        public string featuredGroupsId { get; set; }
        [DataMember]
        public string featuredItemsGroupQuery { get; set; }
        [DataMember]
        public string galleryTemplatesGroupQuery { get; set; }
        [DataMember]
        public bool hasCategorySchema { get; set; }
        [DataMember]
        public string helpBase { get; set; }
        [DataMember]
        public HelperServices helperServices { get; set; }
        [DataMember]
        public string homePageFeaturedContent { get; set; }
        [DataMember]
        public int homePageFeaturedContentCount { get; set; }
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public bool isPortal { get; set; }
        [DataMember]
        public string layerTemplatesGroupQuery { get; set; }
        [DataMember]
        public string livingAtlasGroupQuery { get; set; }
        [DataMember]
        public bool metadataEditable { get; set; }
        [DataMember]
        public List<string> metadataFormats { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string portalHostname { get; set; }
        [DataMember]
        public string portalMode { get; set; }
        [DataMember]
        public string portalName { get; set; }
        [DataMember]
        public PortalProperties portalProperties { get; set; }
        [DataMember]
        public string portalThumbnail { get; set; }
        [DataMember]
        public string region { get; set; }
        [DataMember]
        public List<RotatorPanel> rotatorPanels { get; set; }
        [DataMember]
        public bool showHomePageDescription { get; set; }
        [DataMember]
        public string staticImagesUrl { get; set; }
        [DataMember]
        public string stylesGroupQuery { get; set; }
        [DataMember]
        public bool supportsHostedServices { get; set; }
        [DataMember]
        public string symbolSetsGroupQuery { get; set; }
        [DataMember]
        public string templatesGroupQuery { get; set; }
        [DataMember]
        public string thumbnail { get; set; }
        [DataMember]
        public string units { get; set; }
        [DataMember]
        public string urlKey { get; set; }
        [DataMember]
        public bool useVectorBasemaps { get; set; }
        [DataMember]
        public string vectorBasemapGalleryGroupQuery { get; set; }
        [DataMember]
        public string ipCntryCode { get; set; }
        [DataMember]
        public int httpPort { get; set; }
        [DataMember]
        public int httpsPort { get; set; }
        [DataMember]
        public bool supportsOAuth { get; set; }
        [DataMember]
        public double currentVersion { get; set; }
        [DataMember]
        public List<string> allowedOrigins { get; set; }
    }
}
