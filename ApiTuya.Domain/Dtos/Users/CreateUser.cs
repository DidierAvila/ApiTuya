using ApiTuya.Domain.Custom;

namespace ApiPrueba.Dtos.Users
{
    public class CreateUser
    {
        public string FirstName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }
        public string LastName { get; set; }
    }
}