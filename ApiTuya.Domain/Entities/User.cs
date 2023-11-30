using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiTuya.Domain.Entities
{
    [Table(name: "Usuario")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(name: "IdUsuario")]
        public int Id { get; set; }

        [Column(name: "Nombre", TypeName = "Varchar (255)")]
        public required string FirstName { get; set; }

        [Column(name: "Apellido", TypeName = "Varchar (255)")]
        public required string LastName { get; set; }

        [Column(name: "Email", TypeName = "Varchar (100)")]
        public required string Email { get; set; }

        [Column(name: "Clave", TypeName = "Varchar (20)")]
        public required string Password { get; set; }

        [Column(name: "Rol", TypeName = "Varchar (255)")]
        public required string Role { get; set; }
    }
}