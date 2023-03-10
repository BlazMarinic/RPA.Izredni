using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TeamWorkApp.Models;

namespace TeamWorkApp.Data
{
    public class TeamWorkAppContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public TeamWorkAppContext() : base("name=TeamWorkAppContext")
        {
        }

        public DbSet<TeamWorkApp.Models.Task> Tasks { get; set; }

        public DbSet<TeamWorkApp.Models.TeamMember> TeamMembers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Task>()
                        .HasMany<TeamMember>(s => s.TeamMembers)
                        .WithMany(c => c.Tasks)
                        .Map(cs =>
                        {
                            cs.MapLeftKey("TeamMemberRefId");
                            cs.MapRightKey("TaskRefId");
                            cs.ToTable("TeamMemberTask");
                        });
        }
    }
}
