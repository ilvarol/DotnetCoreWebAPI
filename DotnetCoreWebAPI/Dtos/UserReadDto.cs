namespace DotnetCoreWebAPI.Dtos
{
    public class UserReadDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public Enum.Blood Blood { get; set; }

        public string Cellphone { get; set; }

        public string Adress { get; set; }
    }
}
