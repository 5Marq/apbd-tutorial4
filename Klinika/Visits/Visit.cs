using Klinika.Animals;

namespace Klinika.Visits;

public class Visit
{
    public int id { get; set; }
    public DateTime date { get; set; }
    public Animal animal { get; set; }
    public String description  { get; set; }
    public double price { get; set; }

    public Visit(int id, DateTime date, Animal animal, String description, double price)
    {
        this.id = id;
        this.date = date;
        this.animal = animal;
        this.description = description;
        this.price = price;
    }
}