using System;
class ATMusingSwitch
{
    public static void Mohit()
    {
        /* C# Challenge: Smart ATM System (Switch + Loop)
🏦 Problem Statement:

Design and implement a simple ATM System in C# using a switch statement and looping.

The program should repeatedly show the following menu until the user chooses to exit:

Welcome to MyBank ATM  
1. Check Balance  
2. Deposit Money  
3. Withdraw Money  
4. Exit  

🎯 Requirements:

The program should begin with an initial balance of ₹5000.

After displaying the menu, the user should enter their choice (1–4).

Use a switch statement to handle the menu options:

1 → Show the current balance.

2 → Ask the user for a deposit amount, add it to the balance, and display the new balance.

3 → Ask for a withdrawal amount. If the balance is sufficient, deduct it and show the updated balance; otherwise, display an “Insufficient Funds” message.

4 → Display a goodbye message and exit the program.

If the user enters an invalid choice, display an error message and re-display the menu.

The menu should keep appearing until the user selects Exit.

💡 Bonus Points (Optional):

Display a friendly welcome message only once at the start.

Format the currency neatly (e.g., ₹5000.00).

Handle invalid (non-numeric) inputs gracefully.

🏁 Goal:

Write clean, readable code with proper indentation, comments, and meaningful variable names.
The winner is the one whose solution runs without errors, handles edge cases smoothly, and looks most user-friendly!

    */


            int Balance = 5000;
            Console.WriteLine("Welcome to C# Bank. Please Enter Your Name:");
            string user = Console.ReadLine()??"0";
        Welcomescreen:
            Console.WriteLine("Welcome {0}, Hope You are doing Good. We Wish for your happeniss and Prosperity. Please Select your Option and Press Enter \n1. Check Balance \n2.Deposit Money \n3.Withdraw Money\n4.Exit", user);
            int act = int.Parse(Console.ReadLine() ?? "0");

            if (act != 4)
            {
                switch (act)
                {
                    case 1:
                        Console.WriteLine("Hello {0}, Your Current Balance is Rupees:{1}", user, Balance);
                        break;
                    case 2:
                        Console.WriteLine("Hello {0}, Please Enter the amount to deposit", user);
                        int addtobal = int.Parse(Console.ReadLine() ?? "0");
                        Balance = Balance + addtobal;
                        Console.WriteLine("Hello {0}, Your Current Balance is Rupees:{1}", user, Balance);
                        break;
                    case 3:
                        Console.WriteLine("Hello {0}, Please Enter the amount to Withdraw", user);
                        int subfrombal = int.Parse(Console.ReadLine() ?? "0");
                        if (subfrombal > Balance)
                        {
                            Console.WriteLine("Sorry {0}, You have Insufficent Balance in your account.", user);
                        }
                        else
                        {
                            Balance = Balance - subfrombal;
                            Console.WriteLine("Hello {0}, Your Current Balance is Rupees:{1}", user, Balance);
                        }
                        break;
                    default:
                        Console.WriteLine("Sorry {0}, Please make a valid Choice.", user);
                        goto Welcomescreen;
                }
            UserAct:
                Console.WriteLine("Do You Wish to Make any More Action? (Yes/No)");
                string selection = Console.ReadLine() ?? "0";
                switch (selection)
                {
                    case "Yes":
                        goto Welcomescreen;
                    case "No":
                        Console.WriteLine("Thankyou {0}, For Using Our Services. Please Visit Again!", user);
                        break;
                    default:
                        Console.WriteLine("Sorry {0}, Please make a valid Choice.", user);
                        goto UserAct;
                }
            }
            else
            {
                Console.WriteLine("Thankyou {0}, For Using Our Services. Please Visit Again!", user);
            }

        }

    }