namespace Tic_tac_homework;

class Program
{
    static void ShowBoard(ref char[,] array)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(array[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
    
    static bool CheckVictory(char[,] array)
    {
        for (int i = 0; i < 3; i++)
        {
            if (array[i, 0] == array[i, 1] && array[i, 1] == array[i, 2] && array[i, 2] == 'X')
            {
                Console.WriteLine("X Win");
                return true;
            }

            if (array[i, 0] == array[i, 1] && array[i, 1] == array[i, 2] && array[i, 2] == 'O')
            {
                Console.WriteLine("O Win");
                return true;
            }
        }
        
        for (int i = 0; i < 3; i++)
        {
            if (array[0, i] == array[1, i] && array[1, i] == array[2, i] && array[2, i] == 'X')
            {
                Console.WriteLine("X Win");
                return true;
            }

            if (array[0, i] == array[1, i] && array[1, i] == array[2, i] && array[2, i] == 'O')
            {
                Console.WriteLine("O Win");
                return true;
            }
        }

        if (array[0, 0] == array[1, 1] && array[1, 1] == array[2, 2] && array[2, 2] == 'X')
        {
            Console.WriteLine("X Win");
            return true;
        }

        if (array[0, 0] == array[1, 1] && array[1, 1] == array[2, 2] && array[2, 2] == 'O')
        {
            Console.WriteLine("O Win");
            return true;
        }

        if (array[0, 2] == array[1, 1] && array[1, 1] == array[2, 0] && array[2, 0] == 'X')
        {
            Console.WriteLine("X Win");
            return true;
        }

        if (array[0, 2] == array[1, 1] && array[1, 1] == array[2, 0] && array[2, 0] == 'O')
        {
            Console.WriteLine("O Win");
            return true;
        }

        return false;
    }
    
    // Если нельзя делать ход, то возвращает false. Если ход можно делать то true
    static bool IsMoveAble(ref char[,] array, int x, int y)
    {
        Console.WriteLine(x + " " + y + " ");
        if ((x < 0 || x > 2) || (y < 0 || y > 2)) return false;
        return array[x, y] == '_' ? true : false;
    }
    
    // Если не сделан ход, то возвращает false. Если ход сделан то true
    static bool MakeMove(ref char[,] array, int x, int y, char symbol)
    {
        if (IsMoveAble(ref array, x, y))
        {
            array[x, y] = symbol;
            return true;
        }

        return false;
    }
    
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
        
        // Очередность хода. true - первый, false - второй
        bool order = true;
        char xSymbol = 'X';
        char oSymbol = 'O';
        byte turnNumber = 0;
        bool isGameFinished = false;
        
        char[,] board = new char[3, 3]
        {
            { '_', '_', '_' },
            { '_', '_', '_' },
            { '_', '_', '_' }
        };
    }
}