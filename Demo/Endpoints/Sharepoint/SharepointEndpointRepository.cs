﻿using System.Collections.Generic;
using Verdeler;

namespace Demo.Endpoints.Sharepoint
{
    public class SharepointEndpointRepository : IEndpointRepository<Vendor>
    {
        public IEnumerable<IEndpoint> GetEndpointsForRecipient(Vendor vendor)
        {
            return new List<SharepointEndpoint>
            {
                new SharepointEndpoint { Uri = @"http://sharepoint.com" }
            };
        }
    }
}
