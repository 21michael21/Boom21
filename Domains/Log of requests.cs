using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Boom21.repository;

namespace Boom21.Domains
{

    public class LogOfRequestsFor:MVID
    {
        public int ListClientId { get; set; }

        public int Estate�gentId { get; set; }

        public int CustomerId { get; set; }

        public int SellerId { get; set; }

        LogOfRequestsFor(int Estate�gentid, int ListClientId, int CustomerId, int SellerId)
        {
            this.ListClientId = ListClientId;
            this.Estate�gentId = Estate�gentId;
            this.CustomerId = CustomerId;
            this.SellerId = SellerId;
        }








    }


}