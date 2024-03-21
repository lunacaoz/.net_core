using System.ComponentModel.DataAnnotations;

namespace ASP.Net_core.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string NameUser { get; set; }
    }
}
