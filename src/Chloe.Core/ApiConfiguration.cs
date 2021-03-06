﻿using Swashbuckle.Application;
using System.Web.Http;

namespace Chloe.Core
{
    public static class ApiConfiguration
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config
                .EnableSwagger(c => c.SingleApiVersion("v1", "Chloe"))
                .EnableSwaggerUi();
        }
    }
}
