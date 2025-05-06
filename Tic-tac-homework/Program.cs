namespace Tic_tac_homework;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Привет. Это игра крестики нолики!");
        
        string playerOne = "1";
        string playerTwo = "2";
        
        while (playerOne == null || playerOne == "")
        {
            Console.WriteLine("Введи имя первого игрока");
            playerOne = Console.ReadLine();
        }
        
        while (playerTwo == null || playerTwo == "")
        {
            Console.WriteLine("Введи имя второго игрока");
            playerTwo = Console.ReadLine();
        }
        
        Console.WriteLine("Игрок 1 = " + playerOne);
        Console.WriteLine("Игрок 2 = " + playerTwo);
    }
}