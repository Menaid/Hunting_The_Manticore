using System.Threading.Channels;

int Manticore = 10;
int City = 15;
int round = 1;

Console.WriteLine("Player 1, please enter a distance between 0 and 100.");
int player1 = Convert.ToInt32(Console.ReadLine());
Console.Clear();

do
{
    Console.WriteLine($"Round number: {round}");
    Console.WriteLine($"Healthpoints of the city are: {City}");
    Console.WriteLine($"Healthpoints of the manticore are: {Manticore}");
    Console.WriteLine("Player 2, please enter a canon range you would like to shoot to: ");
    int player2 = Convert.ToInt32(Console.ReadLine());
    
    if (player1 < 0 || player1 > 100)
    {
        Console.WriteLine("Wrong input, please try again. Enter a number between 0 and 100.");
    }

    if (player2 == player1 && round % 15 == 0)
    {
        Manticore -= 10;
        Console.WriteLine("Great Fire & Electric hit, you did 10 dmg to the Manticore.");
    }
    else if (player2 == player1 && round % 5 == 0)
    {
        Manticore -= 3;
        Console.WriteLine("Electric hit, you did 3 dmg to the Manticore.");
    }
    else if (player2 == player1 && round % 3 == 0)
    {
        Manticore -= 3;
        Console.WriteLine("Fire hit, you did 3 dmg to the Manticore.");
    }
    else if (player2 == player1 && round != 0)
    {
        Manticore -= 1;
        Console.WriteLine("Hit, you did 1 dmg to the Manticore.");
    }
    else
    {
        City -= 1;
        Console.WriteLine("The manticore did 1 dmg to the city!");
    }

    if (player2 < player1)
    {
        Console.WriteLine("Miss, to low number");
    }
    else if (player2 > player1)
    {
        Console.WriteLine("Miss, to high number");
    }

    round++;
    
} while (Manticore > 0 || City > 0);