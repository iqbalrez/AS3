namespace SelfService
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Table")]
    public partial class Shirts
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string type { get; set; }

        [Required]
        [StringLength(50)]
        public string brand { get; set; }

        [Required]
        [StringLength(10)]
        public string size { get; set; }

        [Column(TypeName = "money")]
        public decimal price { get; set; }

        public int? stock { get; set; }
    }
}
