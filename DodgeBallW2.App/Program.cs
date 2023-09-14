// See https://aka.ms/new-console-template for more information

void PlayGame()
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
        return;
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
        return;
    }

    if (throwDirection == dodgeDirection)
    {
        Console.WriteLine("You are hit! Game over!");
    }
    else
    {
        Console.WriteLine("You dodged! You won! Good job 😎");
    }
}