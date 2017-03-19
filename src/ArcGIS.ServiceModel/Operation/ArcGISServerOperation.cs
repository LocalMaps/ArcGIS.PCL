﻿using System;
using ArcGIS.ServiceModel.Common;
using System.Runtime.Serialization;

namespace ArcGIS.ServiceModel.Operation
{
    /// <summary>
    /// Base class for calls to an ArcGIS Server operation
    /// </summary>
    public class ArcGISServerOperation : CommonParameters, IHttpOperation
    {
        public ArcGISServerOperation(IEndpoint endpoint, Action beforeRequest = null, Action afterRequest = null)
        {
            LiteGuard.Guard.AgainstNullArgument(nameof(endpoint), endpoint);

            Endpoint = endpoint;
            BeforeRequest = beforeRequest;
            AfterRequest = afterRequest;
        }

        public ArcGISServerOperation(string endpoint, Action beforeRequest = null, Action afterRequest = null)
            : this(new ArcGISServerEndpoint(endpoint), beforeRequest, afterRequest)
        { }        

        [IgnoreDataMember]
        public Action BeforeRequest { get; }

        [IgnoreDataMember]
        public Action AfterRequest { get; }
        
        [IgnoreDataMember]
        public IEndpoint Endpoint { get; }

        [IgnoreDataMember]
        public string RelativeUrl => Endpoint.RelativeUrl;

        public string BuildAbsoluteUrl(string rootUrl) => Endpoint.BuildAbsoluteUrl(rootUrl);        
    }   
}
