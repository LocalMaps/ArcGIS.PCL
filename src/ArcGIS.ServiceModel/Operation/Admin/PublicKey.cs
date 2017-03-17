﻿using ArcGIS.ServiceModel.Common;
using System;
using System.Runtime.Serialization;

namespace ArcGIS.ServiceModel.Operation.Admin
{
    [DataContract]
    public class PublicKey : ArcGISServerOperation
    {
        public PublicKey(Action beforeRequest = null, Action afterRequest = null)
            : base(new ArcGISServerAdminEndpoint(Operations.PublicKey), beforeRequest, afterRequest)
        { }
    }

    [DataContract]
    public class PublicKeyResponse : PortalResponse
    {
        [DataMember(Name = "publicKey")]
        public string PublicKey { get; set; }

        [DataMember(Name = "modulus")]
        public string Mod { get; set; }

        [IgnoreDataMember]
        public byte[] Exponent { get { return PublicKey.HexToBytes(); } }

        [IgnoreDataMember]
        public byte[] Modulus { get { return Mod.HexToBytes(); } }
    }
}
