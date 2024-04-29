namespace Klinika.Animals;

public class Animal
{
    public int id { get; set; }
    public String name { get; set; }
    public String type { get; set; }
    public double weight { get; set; }
    public String furColour { get; set; }
    
    public Animal(int id, String name, String type, double weight, String furColour)
    {
        this.id = id;
        this.name = name;
        this.type = type;
        this.weight = weight;
        this.furColour = furColour;
    }
}