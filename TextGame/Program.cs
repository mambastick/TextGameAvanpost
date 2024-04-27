using TextGame.Items;
using TextGame.Locations;

namespace TextGame;

class Program
{
    static void Main(string[] args)
    {
        // Инициализируем игру
        Game game = Game.Initialize();
        
        // Выводим приветствие и инструкции
        Console.WriteLine("Добро пожаловать в текстовую игру!");
        Console.WriteLine("Введите команду 'осмотреться', чтобы начать.");
        
        // Основной игровой цикл
        while (true)
        {
            // Ввод команды от пользователя
            Console.Write("> ");
            string commandString = Console.ReadLine();

            // Обработка команды
            game.ProcessCommand(commandString);
        }
    }
}