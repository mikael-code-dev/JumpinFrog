//      En groda kan hoppa ett eller två steg åt gången. Man vill skriva en applikation som beräknar på hur många sätt grodan kan ta sig fram exakt x antal steg.
//      Till exempel, om grodan ska ta sig fram 3 steg kan den göra det på följande sätt:
//      Tre korta hopp (1,1,1)En kort och en lång (1,2)En lång och en kort (2,1)
//      dvs, på 3 olika sätt, vilket bör vara outputen från vår applikation.

RunProgram();

void RunProgram()
{
    while (true)
    {
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(" CALCULATE FROG JUMPS\n\n");

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(" The frog can jump one or two steps every jump.");
        Console.WriteLine(" Enter how many steps the frog should jump and");
        Console.WriteLine(" the program tells you how many kombinations ");
        Console.WriteLine(" of jump the frog have to chose from.");

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\n But first select the method to use for the calculation");

        Console.ResetColor();
        Console.WriteLine();

        Console.WriteLine("\n 1 - Iterative Calculation");
        Console.WriteLine(" 2 - Recursive Calculation");
        Console.WriteLine(" 0 - Quit the program");
        Console.Write("\n :> ");

        switch (Console.ReadLine())
        {
            case "1":
                CalculateFrogJumpsIterative();
                break;
            case "2":
                CalculateFrogJumpsRecursion();
                break;
            case "0":
                return;
            default:
                Console.Write("\n ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(" Select 1, 2 or 3            \n");
                Console.ResetColor();
                Console.Write(" ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(" Press any key to continue...");
                Console.ResetColor();
                Console.ReadKey();
                break;
        }
    }
}

void CalculateFrogJumpsIterative()
{
    Int64 numberOfJumps = getUserInput();

    Int64 result;
    Int64 startNum = numberOfJumps + 1;
    Int64[] fibo = new Int64[startNum + 1];
    fibo[0] = 0;
    fibo[1] = 1;

    for (int i = 2; i <= startNum; i++)
    {
        fibo[i] = fibo[i - 2] + fibo[i - 1];
    }

    result = fibo[startNum];
    PrintUI(numberOfJumps, result);
}

void PrintUI(Int64 numberOfJumps, Int64 result)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($" if the frog should jump {numberOfJumps} steps,");
    Console.WriteLine($" The frog can jump in {result} number of combinations");

    Console.ResetColor(); 
    Console.WriteLine("\n\n Press any key to continue...");
    Console.ReadKey();
}

void CalculateFrogJumpsRecursion()
{
    Int64 numberOfJumps = getUserInput() + 1;

    Int64 result = FiboRecursion(numberOfJumps);

    Int64 FiboRecursion(Int64 numberOfJumps)
    {
        if (numberOfJumps == 0 || numberOfJumps == 1)
        {
            return numberOfJumps;
        }
        else
        {
            return FiboRecursion(numberOfJumps - 1) + FiboRecursion(numberOfJumps - 2);
        }
    }

    PrintUI(numberOfJumps - 1, result);
}

Int64 getUserInput()
{
    // label for goto:
    tryAgain:

    Console.Clear();
    Console.WriteLine(" How many jumps should the frog jump?");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(" :> ");
    Console.ResetColor();

    Int64 userInput;
    while (!Int64.TryParse(Console.ReadLine(), out userInput))
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.BackgroundColor = ConsoleColor.White;
        Console.WriteLine("\n\n You can only enter numbers (Integers), try again!");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(" :> ");
        Console.ResetColor();
    }

    if (userInput >= 1963)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n Maximum allowed steps are 1962.The frog doesn't want to jump more steps. Try again!");
        Console.ResetColor();
        Console.WriteLine("\n press any key to continue...");
        Console.ReadKey();
        goto tryAgain;
    }

    return userInput;
}