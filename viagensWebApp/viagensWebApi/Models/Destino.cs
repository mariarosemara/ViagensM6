using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViagensWebApi.Models
{

    [Table("Destinos")]
    public class Destino
    {
        public int Id { get; set; }
        [Required]
        [StringLength(40)]
        public string Nome { get; set; }
        [Required]
        [StringLength(40)]
        public string Valor { get; set; }
        [Required]
        [StringLength(40)]
        public string Localidade { get; set; }
        [Required]
        [StringLength(40)]
        public string Proprietario { get; set; }

    }
}
