namespace FinanceControlDAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Income")]
    public partial class Income
    {
        public long ID { get; set; }

        public long Account_ID { get; set; }

        public long Day { get; set; }

        public long Month { get; set; }

        public long Year { get; set; }

        public long Type_ID { get; set; }

        public long Person_ID { get; set; }

        public double Value { get; set; }

        [Required]
        [StringLength(25)]
        public string Comment { get; set; }

        public virtual Account Account { get; set; }

        public virtual Person Person { get; set; }

        public virtual Type Type { get; set; }
    }
}
