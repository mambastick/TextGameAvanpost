namespace TextGame.Commands;

public class CommandProcessor
{
    private readonly Dictionary<string, ICommand?> _commands = new();

    public CommandProcessor()
    {
        RegisterCommand("осмотреться", new LookCommand());
        RegisterCommand("поднять", new PickCommand());
        RegisterCommand("идти", new GoCommand());
        RegisterCommand("рюкзак", new InventoryCommand());
    }

    private void RegisterCommand(string commandName, ICommand? command)
    {
        _commands[commandName] = command;
    }

    public void ProcessCommand(string commandString, Player.Player player, Game game)
    {
        string[] parts = commandString.Split(' ');
        string commandName = parts[0].ToLower();
        string? param = commandString.Length > commandName.Length + 1 
            ? commandString[(commandName.Length + 1)..] 
            : null;

        if (_commands.TryGetValue(commandName, out var command))
        {
            command.Execute(game, player, param);
        }
        else
        {
            Console.WriteLine("Неизвестная команда.");
        }
    }
}