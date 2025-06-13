using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mime;

namespace Helados.Server.Models
{
    //Marcus Montilla 2024-1783
    public class Helado
    {
        public int Id { get; set; }

        [MaxLength(100, ErrorMessage = "El campo (0) tiene un maximo (1) de caracteres.")]
        public string Nombre { get; set; } = null!;

        [DataType(DataType.MultilineText)]
        [MaxLength(200, ErrorMessage = "El campo (0) tiene un maximo (1) de caracteres.")]
        public string sabor { get; set; } = null!;

        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString ="0:C2")]
        public decimal precio { get; set; }

    }
}
