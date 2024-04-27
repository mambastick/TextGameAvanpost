using TextGame.Commands;
using TextGame.Items;
using TextGame.Locations;

namespace TextGame
{
    public class Game(Location startLocation, Player.Player player)
    {
        public Location CurrentLocation { get; set; } = startLocation;
        public Player.Player Player { get; set; } = player;
        private readonly CommandProcessor _commandProcessor = new();

        public void ProcessCommand(string commandString)
        {
            _commandProcessor.ProcessCommand(commandString, Player, this);
        }

        public static Game Initialize()
        {
            // Создаем предметы
            Item keys = new Item("ключи");
            Item notes = new Item("конспекты");
            Item backpack = new Item("рюкзак");

            // Создаем локации
            var kitchen = new Location(
                name: "кухня",
                exits: [],
                items: [backpack]);
            
            var room = new Location(
                name: "комната", 
                exits: [],
                items: [notes]);
            
            var street = new Location(
                name: "улица", 
                exits: [],
                items: []);
            
            var corridor = new Location(
                name: "коридор", 
                exits: [], 
                items: [keys]);

            // Устанавливаем выходы из локаций
            kitchen.Exits.Add(corridor);
            room.Exits.Add(corridor);
            street.Exits.Add(corridor);
            corridor.Exits.Add(kitchen);
            corridor.Exits.Add(room);
            corridor.Exits.Add(street);

            // Создаем игрока и начальную локацию
            Player.Player player = new Player.Player("Игрок");
            Location startLocation = corridor;

            // Создаем экземпляр игры
            Game game = new Game(startLocation, player);

            return game;
        }
    }
}