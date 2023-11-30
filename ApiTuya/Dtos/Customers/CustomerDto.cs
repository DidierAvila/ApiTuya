using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPrueba.Dtos.Customers
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
    }
}
