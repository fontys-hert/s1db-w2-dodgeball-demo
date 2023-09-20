// See https://aka.ms/new-console-template for more information

bool PlayGame()
{
    Console.WriteLine("The opponent is about to throw the ball!");
    Console.WriteLine("What do you do?\r\n1: Dodge to the left\r\n2: Dodge to the right");

    string? dodgeDirectionInput = Console.ReadLine() ?? "1";
    int left = 1;
    int right = 2;
    int dodgeDirection;

    if (int.TryParse(dodgeDirectionInput, out dodgeDirection) == false)
    {
        Console.WriteLine("What are you doing?!?! Goodbye!");
        return false;
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
        return false;
    }

    if (throwDirection == dodgeDirection)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int healthPoints = 3;

while (healthPoints > 0)
{
    if (PlayGame())
    {
        healthPoints = healthPoints - 1;
        Console.WriteLine("You are hit 🤷. Current health: " + healthPoints);
    }
    else
    {
        Console.WriteLine("You dodged!");
    }
}

if (healthPoints == 0)
{
    Console.WriteLine("Game over!");
}
