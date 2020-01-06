﻿using System.Collections.Generic;

namespace Carbon.WebApplication
{
    public class SwaggerSettings
    {
        public string EndpointUrl { get; set; }
        public string EndpointName { get; set; }
        
        public IList<SwaggerDocument> Documents { get; set; }
        public string RoutePrefix { get; internal set; }

        public class SwaggerDocument
        {
            public string DocumentName { get; set; }
            public OpenApiInformation OpenApiInfo { get; set; }
        }
        public class OpenApiInformation
        {
            public string Title { get; set; }
            public string Version { get; set; }
            public string Description { get; set; }
        }
    }
}
