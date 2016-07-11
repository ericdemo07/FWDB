namespace FWDBApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Framework")]
    public partial class Framework
    {

        public int Id { get; set; }

        [StringLength(100)]
        public string FrameworkName { get; set; }

        public int? UserCount { get; set; }

        [StringLength(100)]
        public string SupportedBy { get; set; }


        public Framework()
        {

        }

        public Framework(int Id, string FrameworkName, int UserCount, string SupportedBy)
        {
            this.Id = Id;
            this.FrameworkName = FrameworkName;
            this.UserCount = UserCount;
            this.SupportedBy = SupportedBy;
        }
    }
}
