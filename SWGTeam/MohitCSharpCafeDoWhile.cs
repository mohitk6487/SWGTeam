using System;
public class MohitCSharpCafeDoWhile
{
    public static void Mohit()
    {
        int NumberOfItem = 4;
        double Bill = 0;
        string[] Item = new string[NumberOfItem];
        int[] price = new int[NumberOfItem];

        Item[0] = "Coffee";
        Item[1] = "Tea";
        Item[2] = "Sandwich";
        Item[3] = "Burger";


        price[0] = 100;
        price[1] = 25;
        price[2] = 150;
        price[3] = 175;

    WelcomeScreen:
        Console.WriteLine("Welcome to C# Cafe \nPlease Let us Know Your name?");

        string name = Console.ReadLine() ?? "0";

        Console.WriteLine("Hello {0}, Would You Like to Order something to eat?(YES/NO)", name);
    PrintMenu:
        string userchoice = Console.ReadLine() ?? "0";
        userchoice = userchoice.ToUpper();
        if (userchoice == "NO")
        {
            Console.WriteLine("Are you Customer?(YES/NO)");
            string iscust = Console.ReadLine() ?? "0";
            iscust = iscust.ToUpper();
            if (iscust == "NO")
            {
                int PIN = 2025;
                int Attempt = 0;
                Console.WriteLine("Hello{0}, Please Eneter PIN to Proceed", name);
                int CPIN = int.Parse(Console.ReadLine() ?? "0");
            CorrectPIN:
                if (CPIN == PIN)

                {
                    int? AdminChoice = null;
                    do
                    {
                    AdminPortal:
                        Console.WriteLine("Hello {0}, Welcome to C# Cafe's Admin Portal, what would you like to do? \n 1. Add Item in Menu. \n 2. Remove Item From Menu. \n 3. Update Price in Menu. \n 4. Logout for Another User.");
                        AdminChoice = int.Parse(Console.ReadLine() ?? "0");
                        switch (AdminChoice)
                        {
                            case 1:
                                Console.WriteLine("Updating this feature. Please Wait");
                                goto AdminPortal;
                            case 2:
                                Console.WriteLine("Updating this feature. Please Wait");
                                goto AdminPortal;
                            case 3:
                                Console.WriteLine("Updating this feature. Please Wait");
                                goto AdminPortal;
                        }
                    } while (AdminChoice != 4);
                    Console.WriteLine("Thankyou {0}, Your changes are updated and visible to dash board \n Logging you out. Have a Nice day Ahead");
                    goto WelcomeScreen;

                }
                else
                {
                    Attempt = Attempt + 1;
                    int ATL = 3;
                    do
                    {
                        ATL--;
                        Console.WriteLine("Sorry wrong PIN Entred Please Try Again, Attempt Left : {0}", ATL);
                    } while (Attempt == 3 || CPIN == PIN);
                    if (CPIN == PIN)
                    {
                        goto CorrectPIN;
                    }
                    else
                    {
                        Console.WriteLine("Maximum Attempt Reached. Redirecting to Welcome Screen.");
                        goto WelcomeScreen;
                    }
                }


            }
            else
            {
                Console.WriteLine("Welcome to C# Cafe – Your Perfect Morning Destination! \n At C# Cafe, we believe that every day should start with flavor, freshness, and a touch of warmth. Nestled in the heart of the city, our cozy breakfast restaurant is designed to offer a delightful experience for everyone, whether you're grabbing a quick bite on the go or enjoying a leisurely morning with friends and family. Our menu is carefully curated to satisfy every taste bud.Start your day with our freshly brewed coffee or aromatic teas, crafted to energize and uplift your mornings.Pair your drink with our signature breakfast sandwiches or gourmet burgers, made with the finest ingredients and bursting with flavor.From classic favorites to innovative creations, each dish is prepared with love and attention to detail, ensuring a memorable dining experience. At C# Cafe, quality and hospitality go hand in hand. Our friendly staff ensures that every guest feels welcome, and our warm, inviting ambiance makes every visit special. Whether it’s a quick breakfast before work, a weekend brunch, or a casual catch-up over coffee, we’re here to make every morning brighter \n C# Cafe – Where Great Mornings Begin.");
                Console.WriteLine("Our Menu");
                Console.WriteLine("{0,-5} {1,-15}", "    ", "Item", "Price");
                Console.WriteLine(new string('-', 28));

                int l = 0;

                // Using do-while loop
                do
                {
                    Console.WriteLine("{0,-5} {1,-15} {2,6:C}", l + 1, Item[l], price[l]);
                    l++;
                } while (l < Item.Length - 1);
            }
            goto WelcomeScreen;
        }


        Console.WriteLine("Hi {0}, We Understand you are desperate to satisfy your Appetite. What would You Like to Order", name);
        Console.WriteLine("Our Menu");
        Console.WriteLine("{0,-5} {1,-15} {2,6}", "S.No.", "Item", "Price");
        Console.WriteLine(new string('-', 28));

        int i = 0;

        // Using do-while loop
        do
        {
            Console.WriteLine("{0,-5} {1,-15} {2,6:C}", i + 1, Item[i], price[i]);
            i++;
        } while (i < Item.Length);
        Console.WriteLine("Currently We are accepting one order at a time please co-oprate. Hit Enter after Item No. or Type 0 to exit");
        int order = int.Parse(Console.ReadLine() ?? "0");
        order = order - 1;
        if (order > 0 && order <= 3)
        {
            do
            {

                Console.WriteLine("Thankyou {0}, for Ordering {1}.It will be prepared shortly.", name, Item[order]);
                Bill = Bill + price[order];
                Console.WriteLine("Do You Wish to Add something else from our delicious Menu?");
                Console.WriteLine("Our Menu");
                Console.WriteLine("{0,-5} {1,-15} {2,6}", "S.No.", "Item", "Price");
                Console.WriteLine(new string('-', 28));

                int l = 0;

                // Using do-while loop
                do
                {
                    Console.WriteLine("{0,-5} {1,-15} {2,6:C}", l + 1, Item[l], price[l]);
                    l++;
                } while (l < Item.Length);
                Console.WriteLine("Currently We are accepting one order at a time please co-oprate. Hit Enter after Item No. and 0 if you want to Pay and Exit");
                order = int.Parse(Console.ReadLine() ?? "0");
            } while (order > 0 && order <= 3);
            Console.WriteLine("Do you Wish to Prepare the Bill and Exit for another User?(YES/NO)");
            string exitmenu = Console.ReadLine() ?? "0";
            exitmenu = exitmenu.ToUpper();
        EXITMENU:
            switch (exitmenu)
            {
                case "YES":
                    Console.WriteLine("Thankyou for Visting C# Cafe. Here's Your Bill");
                    Console.WriteLine(new string('-', 28));
                    Console.WriteLine("{0,-5} {1,-15}", "Item Total", Bill);
                    Console.WriteLine("{0,-5} {1,-15}", "CGST", Bill * 0.05);
                    Console.WriteLine("{0,-5} {1,-15}", "SGST", Bill * 0.05);
                    Console.WriteLine("{0,-5} {1,-15}", "Total", (Bill * 0.1) + Bill);
                    Console.WriteLine("Enter Discount Voucher Code to Avail Discount.\n or EXIT to Proceed and Pay");
                Discount:
                    string Discount = Console.ReadLine() ?? "0";
                    Discount = Discount.ToUpper();
                    switch (Discount)
                    {
                        case "CSHARP10":
                            Console.WriteLine("Thankyou for Visting C# Cafe. Here's Your Bill");
                            Console.WriteLine(new string('-', 28));
                            Console.WriteLine("{0,-5} {1,-15}", "Item Total", Bill);
                            Console.WriteLine("{0,-5} {1,-15}", "DISCOUNT", "-" + (Bill * 0.1));
                            Console.WriteLine("{0,-5} {1,-15}", "CGST", Bill * 0.05);
                            Console.WriteLine("{0,-5} {1,-15}", "SGST", Bill * 0.05);
                            Console.WriteLine("{0,-5} {1,-15}", "Total", Bill);
                            Console.WriteLine("Enter Another Discount Voucher Code to Avail Discount.\n or EXIT to Proceed and Pay");
                            goto Discount;

                        case "FIRST50":
                            Console.WriteLine("Thankyou for Visting C# Cafe. Here's Your Bill");
                            Console.WriteLine(new string('-', 28));
                            Console.WriteLine("{0,-5} {1,-15}", "Item Total", Bill);
                            Console.WriteLine("{0,-5} {1,-15}", "CGST", Bill * 0.05);
                            Console.WriteLine("{0,-5} {1,-15}", "SGST", Bill * 0.05);
                            Console.WriteLine("{0,-5} {1,-15}", "DISCOUNT", 50);
                            Console.WriteLine("{0,-5} {1,-15}", "Total", Bill + (Bill * 0.1) - 50);
                            Console.WriteLine("Enter Another Discount Voucher Code to Avail Discount.\n or EXIT to Proceed and Pay");
                            goto Discount;

                        case "CAFE25":
                            double m = (Bill * 0.25);
                            if (m > 100)
                            {
                                m = 100;
                            }
                            Console.WriteLine("Thankyou for Visting C# Cafe. Here's Your Bill");
                            Console.WriteLine(new string('-', 28));
                            Console.WriteLine("{0,-5} {1,-15}", "Item Total", Bill);
                            Console.WriteLine("{0,-5} {1,-15}", "CGST", Bill * 0.05);
                            Console.WriteLine("{0,-5} {1,-15}", "SGST", Bill * 0.05);
                            Console.WriteLine("{0,-5} {1,-15}", "DISCOUNT", "-" + m);
                            Console.WriteLine("{0,-5} {1,-15}", "Total", Bill - m);
                            Console.WriteLine("Enter Another Discount Voucher Code to Avail Discount.\n or EXIT to Proceed and Pay");
                            goto Discount;
                    }
                    break;
                case "NO":
                    {
                        goto PrintMenu;
                    }
                default:
                    Console.WriteLine("Invalid Selection. Please Try Again");
                    goto EXITMENU;

            }

        }
        else if (order == -1)
        {
            Console.WriteLine("Welcome to C# Cafe – Your Perfect Morning Destination! \n At C# Cafe, we believe that every day should start with flavor, freshness, and a touch of warmth. Nestled in the heart of the city, our cozy breakfast restaurant is designed to offer a delightful experience for everyone, whether you're grabbing a quick bite on the go or enjoying a leisurely morning with friends and family. Our menu is carefully curated to satisfy every taste bud.Start your day with our freshly brewed coffee or aromatic teas, crafted to energize and uplift your mornings.Pair your drink with our signature breakfast sandwiches or gourmet burgers, made with the finest ingredients and bursting with flavor.From classic favorites to innovative creations, each dish is prepared with love and attention to detail, ensuring a memorable dining experience. At C# Cafe, quality and hospitality go hand in hand. Our friendly staff ensures that every guest feels welcome, and our warm, inviting ambiance makes every visit special. Whether it’s a quick breakfast before work, a weekend brunch, or a casual catch-up over coffee, we’re here to make every morning brighter \n C# Cafe – Where Great Mornings Begin.");

        }
        else
        {
            Console.WriteLine("Hello {0}, Please Make a valid selection", name);
            goto PrintMenu;
        }

    }
}