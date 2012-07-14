using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace DomainModel.Domain
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<DataBaseContext>
    {
        protected override void Seed(DataBaseContext context)
        {
            context.Interests.Add(new Interest {InterestId = 1, InterestName = "daw"});
            context.SaveChanges();
        }

    }
}
