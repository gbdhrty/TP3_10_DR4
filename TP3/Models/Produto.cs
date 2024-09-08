using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP3.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Preco { get; set;}
    }
}
