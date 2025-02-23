using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace legos_api.Legos.Model1
{
    [Table("lego")]
    public class Lego
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("model")]
        public string Model { get; set; }

        [Required]
        [Column("piece")]
        public int Piece { get; set; }

        [Required]
        [Column("price")]
        public int Price {  get; set; }
    }
}
