namespace FWDBApp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FrameworkModel : DbContext
    {
        public FrameworkModel()
            : base("name=FrameworkModel")
        {
        }

        public virtual DbSet<Framework> Frameworks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
