using Klinika.Animals;
using Klinika.Visits;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

List<Animal> animals = new List<Animal>
{
    new Animal(1, "Burek", "Dog", 12.5, "Brown"),
    new Animal(2, "Mruczek", "Cat", 4.5, "Black"),
    new Animal(3, "Puszek", "Cat", 5.5, "White"),
};

Configuartion.SetAnimalListForAnimal(animals);
Configuration.SetAnimalListForVisit(animals);

app.RegisterEndpointsForAnimals();
app.RegisterEndpointsForVisits();
app.Run();