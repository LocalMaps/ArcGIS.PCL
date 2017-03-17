﻿using ArcGIS.ServiceModel.Common;
using System;
using System.Runtime.Serialization;

namespace ArcGIS.ServiceModel.Operation.Admin
{
    [DataContract]
    public class ServiceStatus : ArcGISServerOperation
    {
        public ServiceStatus(ServiceDescription serviceDescription, Action beforeRequest = null, Action afterRequest = null)
            : base (new ArcGISServerAdminEndpoint(string.Format(Operations.ServiceStatus, serviceDescription.Name, serviceDescription.Type)), beforeRequest, afterRequest)
        { }
    }

    [DataContract]
    public class ServiceStatusResponse : PortalResponse
    {
        [DataMember(Name = "configuredState")]
        public string Expected { get; set; }

        [DataMember(Name = "realTimeState")]
        public string Actual { get; set; }
    }
}
