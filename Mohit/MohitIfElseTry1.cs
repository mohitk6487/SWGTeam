using System;

class AritmaticIfElse
{
    public static void Mohit()
    {
        Console.WriteLine("Welcome to C# Tutorial for If Else Staement with Arithmatic OPerations \nPlease Enter First Number:");
        int? FirstNumber = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Please Enter Second Number");
        int? SecondNumber = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Please Enter Arithmatic Operation:");
        string? opp = Console.ReadLine();
        if (opp == "Add" || opp == "+" || opp == "Sum" || opp == "add" || opp == "sum")
        {
            int? add = FirstNumber + SecondNumber;
            Console.WriteLine("Addtion of Provided Number is {0}", add);
        }
        else if (opp == "Sub" || opp == "-" || opp == "sub" || opp == "Minus" || opp == "minus")
        {
            int? Sub = FirstNumber - SecondNumber;
            Console.WriteLine("Subtracting Second Number from First Number You will get {0}", Sub);
        }
        else if (opp == "Div" || opp == "/" || opp == "div" || opp == "Divide" || opp == "divide")
        {
            if (SecondNumber == 0)
            {
                Console.WriteLine("As Your Dvisior is 0 so it is a not defined State");
            }
            else
            {
                int? div = FirstNumber / SecondNumber;
                Console.WriteLine("Dividing Second Number from First Number You will get {0}", div);
            }
        }
        else if (opp == "Mul" || opp == "*" || opp == "mul" || opp == "Multiply" || opp == "MultiPly")
        {
            int? Mul = FirstNumber * SecondNumber;
            Console.WriteLine("Multiplying Both Numbers You will get {0}", Mul);
        }
        else
        {
            Console.WriteLine("I am not able to Understand this Arithmetic Operation");
        }
    }
}