using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Boom21.repository;

namespace Boom21.Domains
{

    public class Estate�gent:MVID
    {
        public int Estate�gentid { get; set; }

        public string FirstName { get; set; }

        public string Phone { get; set; }

        public int ListClient { get; set; }

        Estate�gent(int Estate�gentid, string FirstName,  string Phone, int ListClient)
        {
            this.Estate�gentid = Estate�gentid;
            this.FirstName = FirstName;
            this.Phone = Phone;
            this.ListClient = ListClient;
        }








    }


}