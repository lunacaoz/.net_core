using System.ComponentModel.DataAnnotations;

namespace ASP.Net_core.Model
{
    public class Donhang
    {
        [Key]
        public int Id { get; set; }
        public int user_id { get; set; }
        public int Product_id { get; set; }
    }
}
