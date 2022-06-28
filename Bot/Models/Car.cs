namespace Bot.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public CarType cartype { get; set; }
        public int CarTypeId { get; set; }

    }
}