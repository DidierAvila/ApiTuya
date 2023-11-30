using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiTuya.Domain.Entities
{
    [Table(name: "Orden")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(name: "Id")]
        public int Id { get; set; }

        [Column(name: "ClienteId")]
        public int CustomerId { get; set; }

        [Column(name: "Radicado", TypeName = "Varchar (15)")]
        public required string Radicado { get; set; }

        [Column(name: "FechaCreacion")]
        public required DateTime CreateDate { get; set; }

        [Column(name: "Estado", TypeName = "Varchar (20)")]
        public required string Status { get; set; }
    }
}