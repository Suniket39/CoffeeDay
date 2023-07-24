using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace LibraryManagement.Models
{
    public class ReservationModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string name { get; set; }
        public string tablefor { get; set; }
        public string occasion { get; set; }
        [Required]
        public string email { get; set; }
        public string message { get; set; }
    }
}
