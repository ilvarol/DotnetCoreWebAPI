using System.ComponentModel.DataAnnotations;

namespace DotnetCoreWebAPI.Dtos
{
    public class UserCreateDto
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Surname { get; set; }

        public Enum.Blood Blood { get; set; }

        [MaxLength(50)]
        public string Cellphone { get; set; }

        [MaxLength(500)]
        public string Adress { get; set; }
    }
}
