using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RealEstateObject.Domains
{

    public class RealEstateObject
    {
        public int CadastralNumber { get; set; }

        public int CustomerId { get; set; }

        public string Location { get; set; }

        public int Estate�gentId { get; set; }

        RealEstateObject(int CadastralNumber, int CustomerId, string Location, int Estate�gentId)
        {
            this.CadastralNumber = CadastralNumber;
            this.CustomerId = CustomerId;
            this.Location = Location;
            this.Estate�gentId = Estate�gentId;
        }








    }


}