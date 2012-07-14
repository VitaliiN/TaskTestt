using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace DomainModel.Domain
{
    public class DatabaseInitializer : IDatabaseInitializer<DataBaseContext>
    {
        public void InitializeDatabase(DataBaseContext context)
        {
            if (context.Database.Exists())
                context.Database.Delete();
            context.Database.Create();
        }
    }
}
