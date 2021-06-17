namespace SelfService
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Table")]
    public partial class Table
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

        public int price { get; set; }

        public int? stock { get; set; }
    }
}
