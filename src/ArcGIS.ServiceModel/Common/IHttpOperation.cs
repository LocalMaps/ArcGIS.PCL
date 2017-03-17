﻿namespace ArcGIS.ServiceModel.Common
{
    using System;

    public interface IHttpOperation
    {
        IEndpoint Endpoint { get; }

        Action BeforeRequest { get; }

        Action AfterRequest { get; }
    }
}
