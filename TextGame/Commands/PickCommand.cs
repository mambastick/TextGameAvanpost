namespace TextGame.Commands;

public class PickCommand : ICommand
{
    public void Execute(Game game, Player.Player player, string? param)
    {
        if (string.IsNullOrEmpty(param))
        {
            Console.WriteLine("Вы не указали, что хотите поднять!");
            return;
        }

        game.Player.Pick(game, param);
    }
}