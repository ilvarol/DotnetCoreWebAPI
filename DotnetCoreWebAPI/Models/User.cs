using System.ComponentModel.DataAnnotations;

namespace DotnetCoreWebAPI.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Surname { get; set; }

        [Display(Name = "Blood Group")]
        public Blood Blood { get; set; }

        [MaxLength(50)]
        public string Cellphone { get; set; }

        [MaxLength(500)]
        public string Adress { get; set; }

    }
}
