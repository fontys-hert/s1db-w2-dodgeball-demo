// See https://aka.ms/new-console-template for more information

int hp = 3;

int OpponentTurn(int currentHealthPoints)
{
    Console.WriteLine("The opponent is about to throw the ball!");
    Console.WriteLine("What do you do?\r\n1: Dodge to the left\r\n2: Dodge to the right");

    string? dodgeDirectionInput = Console.ReadLine() ?? "1";
    int left = 1;
    int right = 2;

    if (int.TryParse(dodgeDirectionInput, out var dodgeDirection) == false)
    {
        Console.WriteLine("What are you doing?!?! Goodbye!");
        return currentHealthPoints;
    }

    Random random = new Random();
    int throwDirection = random.Next(1, 3);

    if (throwDirection == left)
    {
        Console.WriteLine("Opponent is going to throw to the left!");
    }
    else if (throwDirection == right)
    {
        Console.WriteLine("Opponent is going to throw to the right!");
    }
    else
    {
        Console.WriteLine("Sigh... moron.");
        return currentHealthPoints;
    }

    if (throwDirection == dodgeDirection)
    {
        Console.WriteLine("You are hit!");
        int newHealthPoints = currentHealthPoints - 1;
        return newHealthPoints;
    }
    else
    {
        Console.WriteLine("You dodged!");
        return currentHealthPoints;
    }
}


while (hp > 0)
{
    hp = OpponentTurn(hp);
    Console.WriteLine($"Round over. Your HP is {hp}");
}

Console.WriteLine("Game over!");