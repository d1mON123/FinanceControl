namespace FinanceControlDAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Account()
        {
            Incomes = new HashSet<Income>();
            Outlays = new HashSet<Outlay>();
        }

        public long ID { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        [Column(TypeName = "real")]
        public double CurrentAmount { get; set; }

        public long IconID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Income> Incomes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Outlay> Outlays { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
