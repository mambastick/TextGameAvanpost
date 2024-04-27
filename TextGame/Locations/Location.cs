using TextGame.Items;

namespace TextGame.Locations;

public class Location(string name, List<Location> exits, List<Item?> items) : IInspectable
{
    public string Name { get; set; } = name;
    public List<Location> Exits { get; set; } = exits;
    public List<Item?> Items { get; set; } = items;

    public void Inspect()
    {
        var itemNames = Items.Select(item => item != null ? item.Name : "нет предметов").ToList();
        var exitNames = Exits.Select(exit => exit.Name).ToList();
    
        Console.WriteLine(
            $"Вы находитесь в {Name}, на столе лежат предметы: {string.Join(", ", itemNames)}, а пройти можно в: {string.Join(", ", exitNames)}");
    }
}