using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DomainModel.Domain
{
    public class DataBaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Interest> Interests { get; set; }

        public DbSet<MaritalStatus> MaritalStatuses { get; set; }

        public DbSet<FriendShipRequest> Requests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<FriendShipRequest>().HasRequired(x => x.FromUser) //or HasOptional
                .WithMany() //Unidirectional
                .Map(x => x.MapKey("FromUser")) //FK column Name
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FriendShipRequest>().HasRequired(x => x.ToUser) //or HasOptional
                .WithMany() //Unidirectional
                .Map(x => x.MapKey("ToUser")) //FK column Name
                .WillCascadeOnDelete(false);
        }





    }
}
