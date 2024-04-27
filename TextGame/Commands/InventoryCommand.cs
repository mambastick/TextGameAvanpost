namespace TextGame.Commands;

public class InventoryCommand : ICommand
{
    public void Execute(Game game, Player.Player player, string? param)
    {
        if (player.Inventory.Count > 0)
        {
            Console.WriteLine("Ваш инвентарь:");
            foreach (var item in player.Inventory)
            {
                Console.WriteLine(item.Name);
            }
        }
        else
        {
            Console.WriteLine("Ваш инвентарь пуст.");
        }
    }
}