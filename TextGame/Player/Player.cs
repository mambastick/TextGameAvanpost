using TextGame.Items;

namespace TextGame.Player;

public class Player(string name) : IPickable
{
    public string Name { get; set; } = name;
    public List<Item?> Inventory { get; set; } = [];

    public void Pick(Game game, string itemName)
    {
        Item? item = game.CurrentLocation.Items.Find(i => i.Name.ToLower().Equals(itemName, StringComparison.CurrentCultureIgnoreCase));
        if (item != null)
        {
            Inventory.Add(item);
            Console.WriteLine($"Вы положили в рюкзак: {itemName}");
            game.CurrentLocation.Items.Remove(item);
        }
        else
        {
            Console.WriteLine($"Предмет '{itemName}' не найден в этой комнате.");
        }
    }
}