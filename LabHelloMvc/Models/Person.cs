

namespace LabHelloMvc.Models
{
    public class Person
    {
        // Primary key
        public int PersonId { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public int PhoneNumber { get; set; }

        public string Email { get; set; } = string.Empty;

    }
}
