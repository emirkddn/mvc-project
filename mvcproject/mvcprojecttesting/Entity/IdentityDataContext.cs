using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using mvcprojecttesting.Identity;

namespace mvcprojecttesting.Entity
{
    public class IdentityDataContext : IdentityDbContext<ApplicationUser>
    {
        public IdentityDataContext() : base("ikiikidortDb")
        {
            
        }
    }
}