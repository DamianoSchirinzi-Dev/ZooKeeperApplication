namespace ZooKeeperApplication.Models
{
    public class Animal
    {
        public string Name { get; set; }    
        public string Description { get; set; }
        public int Id { get; set; }
        public DateTime BirthDate { get; set; }

        public Animal( string name, string description, int id, DateTime birthDate)
        {
            Name = name;
            Description = description;
            Id = id;
            BirthDate = birthDate;
        }
    }
}
