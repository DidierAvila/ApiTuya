using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiTuya.Domain.Entities
{
    [Table(name: "Cliente")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(name: "Id")]
        public int Id { get; set; }

        [Column(name: "Nombre", TypeName = "Varchar (100)")]
        public string FirstName { get; set; }

        [Column(name: "Apellido", TypeName = "Varchar (100)")]
        public string LastName { get; set; }

        [Column(name: "Documento", TypeName = "Varchar (15)")]
        public string Document { get; set; }

        [Column(name: "Email", TypeName = "Varchar (100)")]
        public string Email { get; set; }
    }
}