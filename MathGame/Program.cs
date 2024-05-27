while(true)
{

    Console.WriteLine("Select any operation from below:");
    Console.WriteLine("A - Addition");
    Console.WriteLine("S - Substraction");
    Console.WriteLine("M - Multiplication");
    Console.WriteLine("D - Diviion");
    Console.WriteLine("R - Modulus");
    Console.WriteLine("E - Exit");

    char op = (char)Console.Read();
    if (!(op == 'A' || op == 'S' || op == 'M' || op == 'D' || op == 'R' || op=='E'))
    {
        Console.WriteLine("Invalid operator. \n Program terminated.");
        return;
    }
    var rand = new Random();
    int op1 = rand.Next(101);
    int op2 = rand.Next(1, 101);
    switch(op)
    {
        case 'A': Console.WriteLine(op1 + "+" + op2);break; 
        case 'S': Console.WriteLine(op1 + "-" + op2);break;
        case 'M': Console.WriteLine(op1 + "*" + op2); break;
        case 'D': Console.WriteLine(op1 + "/" + op2); break;
        case 'R': Console.WriteLine(op1 + "%" + op2); break;
        case 'E': Console.WriteLine("YOu choose to exit, program terminated"); return;
    }
    
    string input = Console.ReadLine();
    input = Console.ReadLine();
    bool success = int.TryParse(input, out int ans);
    if (success == false)
    {
        Console.WriteLine("Wrong answer. \n Program terminated.");
        return;
    }

    switch (op)
    {
        case 'A':
            if (ans == op1 + op2)
            {
                Console.WriteLine("Correct answer.");
                Console.WriteLine("Select next operation.");
            }
            else
            {
                Console.WriteLine("Wrong answer");
            }
            break;
        case 'S':
            if (ans == op1 - op2)
            {
                Console.WriteLine("Correct answer.");
                Console.WriteLine("Select next operation.");
            }
            else
            {
                Console.WriteLine("Wrong answer");
            }
            break;
        case 'M':
            if (ans == op1 * op2)
            {
                Console.WriteLine("Correct answer.");
                Console.WriteLine("Select next operation.");
            }
            else
            {
                Console.WriteLine("Wrong answer");
            }
            break;
        case 'D':
            if (ans == op1 / op2)
            {
                Console.WriteLine("Correct answer.");
                Console.WriteLine("Select next operation.");
            }
            else
            {
                Console.WriteLine("Wrong answer");
            }
            break;
        case 'R':
            if (ans == op1 % op2)
            {
                Console.WriteLine("Correct answer.");
                Console.WriteLine("Select next operation.");
            }
            else
            {
                Console.WriteLine("Wrong answer");
            }
            break;
    }

}