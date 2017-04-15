namespace FinanceControlDAL.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Person")]
    public partial class Person
    {
        [Key]
        public long ID { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        public virtual ICollection<Income> Incomes { get; set; } = new HashSet<Income>();

        public virtual ICollection<Outlay> Outlays { get; set; } = new HashSet<Outlay>();

        public override string ToString()
        {
            return Name;
        }
    }
}
