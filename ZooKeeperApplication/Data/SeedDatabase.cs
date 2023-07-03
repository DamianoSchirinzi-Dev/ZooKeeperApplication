using ZooKeeperApplication.Models;

namespace ZooKeeperApplication.Data
{
    public static class SeedDatabase 
    {
        public static void Initialize(ZooContext context)
        {
            context.Database.EnsureCreated();


            if (context.Animals.Any())
            {
                return;
            }

            var animals = new Animal[]
            {
                new Animal("Lion", "The lion is a large felid of the genus Panthera.", 1, DateTime.Now),
                new Animal("Elephant", "The elephant is the largest land animal.", 2, DateTime.Now),
                new Animal("Giraffe", "The giraffe is the tallest living terrestrial animal.", 3, DateTime.Now),
                new Animal("Tiger", "The tiger is the largest cat species.", 4, DateTime.Now),
                new Animal("Penguin", "Penguins are a group of flightless birds.", 5, DateTime.Now),
                new Animal("Dolphin", "Dolphins are marine mammals known for their intelligence.", 6, DateTime.Now),
                new Animal("Kangaroo", "Kangaroos are marsupials native to Australia.", 7, DateTime.Now),
                new Animal("Gorilla", "Gorillas are ground-dwelling, predominantly herbivorous apes.", 8, DateTime.Now)
            };

            foreach(var animal in animals)
            {
                context.Animals.Add(animal);
            }

            context.SaveChanges();
        }
    }
}
