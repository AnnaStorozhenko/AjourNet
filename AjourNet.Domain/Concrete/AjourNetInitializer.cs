using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AjourNet.Domain.Concrete
{
    public class AjourNetInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<AjourNetContext>
    {
        protected override void Seed(AjourNetContext context)
        {
   
        }
    }
}