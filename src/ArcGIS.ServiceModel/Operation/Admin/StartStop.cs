﻿using ArcGIS.ServiceModel.Common;
using System;
using System.Runtime.Serialization;

namespace ArcGIS.ServiceModel.Operation.Admin
{
    [DataContract]
    public class StartService : ArcGISServerOperation
    {
        public StartService(ServiceDescription serviceDescription, Action beforeRequest = null, Action afterRequest = null)
            : base(new ArcGISServerAdminEndpoint(string.Format(Operations.StartService, serviceDescription.Name, serviceDescription.Type)), beforeRequest, afterRequest)
        { }
    }

    [DataContract]
    public class StopService : ArcGISServerOperation
    {
        public StopService(ServiceDescription serviceDescription, Action beforeRequest = null, Action afterRequest = null)
            : base(new ArcGISServerAdminEndpoint(string.Format(Operations.StopService, serviceDescription.Name, serviceDescription.Type)), beforeRequest, afterRequest)
        { }
    }

    [DataContract]
    public class StartStopServiceResponse : PortalResponse
    {
        [DataMember(Name = "status")]
        public string Status { get; set; }
    }
}
