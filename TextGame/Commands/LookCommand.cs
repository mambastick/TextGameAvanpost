namespace TextGame.Commands;

public class LookCommand : ICommand
{
    public void Execute(Game game, Player.Player player, string? param)
    {
        game.CurrentLocation.Inspect();
    }
}