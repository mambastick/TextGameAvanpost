using TextGame.Locations;

namespace TextGame.Commands;

public class GoCommand : ICommand
{
    public void Execute(Game game, Player.Player player, string param)
    {
        var targetLocation = game.CurrentLocation.Exits.Find(exit => exit.Name.ToLower().Equals(param, StringComparison.CurrentCultureIgnoreCase));
        if (targetLocation != null)
        {
            game.CurrentLocation = targetLocation;
            Console.WriteLine($"Вы перешли в {targetLocation.Name}.");
            game.CurrentLocation.Inspect();
        }
        else
        {
            Console.WriteLine("Такой выход не найден.");
        }
    }
}