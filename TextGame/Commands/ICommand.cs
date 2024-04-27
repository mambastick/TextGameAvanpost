namespace TextGame.Commands;

public interface ICommand
{
    void Execute(Game game, Player.Player player, string? param);
}