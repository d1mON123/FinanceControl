namespace FinanceControlDAL.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Outlay")]
    public partial class Outlay
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        [Required]
        public long Account_ID { get; set; }

        [Required]
        public long Day { get; set; }

        [Required]
        public long Month { get; set; }

        [Required]
        public long Year { get; set; }

        [Required]
        public long Type_ID { get; set; }

        [Required]
        public long Person_ID { get; set; }

        [Required]
        public double Value { get; set; }

        [Required]
        [StringLength(25)]
        public string Comment { get; set; }

        [ForeignKey("Account_ID")]
        public virtual Account Account { get; set; }

        [ForeignKey("Person_ID")]
        public virtual Person Person { get; set; }

        [ForeignKey("Type_ID")]
        public virtual Type Type { get; set; }
    }
}
