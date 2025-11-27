using System;
using System.Data.Common;
using System.Net.Quic;
using System.Security.Cryptography.X509Certificates;
class MohitFruitBasket
{

    public static void Mohit()
    {
        List<string> Fruits = new List<string>() { "APPLE", "BANANA", "CHERRY", "DRAGON FRUIT" };
        List<double> Price = new List<double>() { 250, 60, 120, 40 };
        int attempt = 3;
        //bool? IsGuest = null;
        bool EmptyCart = false;
        int ModifyCart = 1;
        List<string> CartItem = new List<string>();
        List<double> ItemPrice = new List<double>();
        List<double> qty = new List<double>();
        List<double> ItemQtyPrice = new List<double>();
        void Menu()
        {
            int i = 0;
            Console.WriteLine("{0, -5} {1, -20} {2, -35}", "S.NO.", "| Fruit", "| Price/KG");
            foreach (string fruit in Fruits)
            {

                Console.WriteLine(new string('-', 50));
                Console.WriteLine("{0, -5} {1, -20} {2, -35}", i + 1, "| " + fruit, "|  Rs." + Price[i]);
                i++;
            }
        }
        void Cart()
        {
            int i = 0;
            Console.WriteLine("{0, -5} {1, -15} {2,-30} {3, -40} {4, -55}", "S. No.", "|  Fruit", "|  Price/KG", "|  Quantity", "|  Price");
            foreach (string IteminCart in CartItem)
            {
                Console.WriteLine(new string('-', 80));
                Console.WriteLine("{0, -5} {1, -15} {2,-30} {3, -40} {4, -55}", i++, "|  " + IteminCart, "|  " + ItemPrice[i], "|  " + qty[i], "|  " + ItemQtyPrice[i]);
                i++;
            }
            Console.WriteLine("{0, -5} {1, -15} {2,-30} {3, -40} {4, -55}", " ", "|  Total Weight of Basket" , "|  "+qty.Sum(), "|  Total Price" , "|  " + ItemQtyPrice.Sum());
        }
        if (Fruits.Count == Price.Count) //Entring Welcome Page
        {
            Console.WriteLine("Welcome to C# Fruit Basket\nWe Offer you Fresh Fruits Round The Clock\nPlease Let us Know Your Name");
            string UserName = Console.ReadLine() ?? "Guest";
            UserName = UserName.ToUpper();
            Console.WriteLine("Hello {0}, Are you here to add some FRESH FRUITS in Your Basket?(YES/NO)", UserName);
            void UserCart()
            {
                while (ModifyCart > 0 && ModifyCart < 3)
                {
                    Console.WriteLine("Our Menu");
                    if (EmptyCart)
                    {
                        Console.WriteLine($"Hello {UserName}, Your Fruit Basket is Empty. Please Add Fruits to Your Fruit Basket");
                        Menu();
                        Console.WriteLine("Please Select from following Option.\n1. Add Fruit to Fruit Basket.\n2. Remove Fruit From Your Fruit Basket.\n3. Modify Quantity in your Fruit Basket.");
                    }
                    else
                    {
                        Console.WriteLine($"Hello {UserName}You Have following Items in Your Fruit Basket");
                        Cart();
                        Console.WriteLine("Do You Want to Add More Fruits in Your Basket?");

                        Console.WriteLine("Please Select from following Option.\n1. Add Fruit to Fruit Basket.\n2. Remove Fruit From Your Fruit Basket.\n3. Modify Quantity in your Fruit Basket.\n0. To Pay and Checkout");
                    }
                    string ModifyCartOPtion = Console.ReadLine()??  "No Value";
                    bool MCO = int.TryParse(ModifyCartOPtion, out ModifyCart);
                    if (MCO)
                    {
                        switch (ModifyCart)
                        {
                            case 1:
                                int AddFruit = 0;
                                Console.WriteLine("Our Menu");
                                Menu();
                                Console.WriteLine("Please Select Fruit's S.No. to Add in your Fruit Basket");
                                string AddToCart = Console.ReadLine() ?? "Empty";
                                bool AF = int.TryParse(AddToCart, out AddFruit);
                                if (AF)
                                {
                                    if (AddFruit > 0 && AddFruit <= Fruits.Count)
                                    {
                                        AddFruit--;
                                        string FruitToAdd = Fruits[AddFruit];
                                        Console.WriteLine("Please Enter Quantity:");
                                        string qt = Console.ReadLine() ?? "0";
                                        double itemqty = 0;
                                        bool qt1 = double.TryParse(qt, out itemqty);
                                        if (qt1)
                                        {
                                            double PriceOfItem = Price[AddFruit];
                                            CartItem.Add(FruitToAdd);
                                            qty.Add(itemqty);
                                            ItemPrice.Add(PriceOfItem);
                                            ItemQtyPrice.Add(itemqty * PriceOfItem);
                                            Console.WriteLine($"{FruitToAdd} is added to Your Fruit Basket");
                                            Cart();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid S No. Entred. Please add a Valid S. No. from the Menu");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Input");
                                }
                                break;

                            case 2:
                                int RemFruitsno = 0;
                                Console.WriteLine("Your Fruit Basket");
                                Cart();
                                Console.WriteLine("Please Enter the S.No. of Fruit you Want to Remove from the Fruit Basket");
                                string RemF =Console.ReadLine()?? "0";
                                bool RF = int.TryParse(RemF, out RemFruitsno);
                                if (RF)
                                {
                                    if (RemFruitsno > 0 && RemFruitsno <= CartItem.Count)
                                    {
                                        String RemFruit = CartItem[RemFruitsno - 1];
                                        CartItem.RemoveAt(RemFruitsno - 1);
                                        ItemPrice.RemoveAt(RemFruitsno - 1);
                                        qty.RemoveAt(RemFruitsno - 1);
                                        ItemQtyPrice.RemoveAt(RemFruitsno - 1);
                                        Console.WriteLine($"{RemFruit} is Removed from Your Cart.\n Your Updated Fruit Basket is:");
                                        Cart();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid Serial No. Entered");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Serial No. Entered");
                                }
                                    break;
                             case 3:
                                int ModifyFruitsno = 0;
                                double UpdateQty = 0;
                                Console.WriteLine("You Cart");
                                Cart();
                                Console.WriteLine("Please Enter the S.No. of Fruit you Want to Modify Quantity from your Fruit Basket");
                                string ModF = Console.ReadLine() ?? "0";
                                bool MF = int.TryParse(ModF, out RemFruitsno);
                                if (MF)
                                {
                                    if (ModifyFruitsno > 0 && ModifyFruitsno <= CartItem.Count)
                                    {
                                        String ModifyFruit= CartItem[ModifyFruitsno - 1];
                                        double ModQty = qty[ModifyFruitsno - 1];
                                        Console.WriteLine($"Current Qty is {ModQty} of {ModifyFruitsno}. Please Enter the updated qty");
                                        string UpQty = Console.ReadLine() ?? string.Empty;
                                        bool UQ = double.TryParse(UpQty, out UpdateQty);
                                        if (UQ)
                                        {
                                            if (UpdateQty == 0)
                                            {
                                                CartItem.RemoveAt(ModifyFruitsno - 1);
                                                ItemQtyPrice.RemoveAt(ModifyFruitsno - 1);
                                                ItemPrice.RemoveAt(ModifyFruitsno - 1);
                                                qty.RemoveAt(ModifyFruitsno - 1);
                                                Console.WriteLine($"As {ModifyFruit}'s Qty is updated to 0 so {ModifyFruit} is removed from your Fruit Basket. Your Updated Basket is now:");
                                                Cart();
                                            }
                                            else
                                            {
                                                qty[ModifyFruitsno-1] = UpdateQty;
                                                ItemQtyPrice[ModifyFruitsno-1] = UpdateQty * ItemPrice[ModifyFruitsno-1];
                                                Console.WriteLine($"Quantity for {ModifyFruit} is updated from {ModQty} to {UpdateQty}. Your Updated Fruit Basket is now");
                                                Cart();
                                            }
                                        }
                                        
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid Serial No. Entered");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Serial No. Entered");
                                }
                                    break;

                                
                        }
                    }
                }
            }
            string admn = Console.ReadLine() ?? string.Empty;
            admn = admn.ToUpper();
            while (admn != "YES" && admn != "NO")
            {
                Console.WriteLine("Invalid Selection. Please Try Again");
                admn = Console.ReadLine() ?? string.Empty;
                admn = admn.ToUpper();
            }
            Console.WriteLine("Are You Staff?(Yes/No)");
            //Implement staff logic here
            string staff = Console.ReadLine() ?? string.Empty; 
            staff = staff.ToUpper();
            
            while (staff != "YES" && staff != "NO")
            {
                //Console.WriteLine($"Staff Sleection:{staff}");
                Console.WriteLine("Invalid Selection. is loop stuck here Please Try Again");
                staff = Console.ReadLine() ?? string.Empty;
                staff = staff.ToUpper();
            }
            if (staff == "NO")
            {
                Menu();
                
                Console.WriteLine("We feel we are offering the best quality fruits in this Range.\n In Fact apply cooupn  Type YES to add Fruits in your Basket or NO to Exit");//Fix Coupons
                string UserChoice = Console.ReadLine() ?? string.Empty;
                UserChoice = UserChoice.ToUpper();
                while(UserChoice != "YES" && UserChoice != "NO" && attempt>0)
                {
                    attempt--;
                    Console.WriteLine($"Invalid Choice. Please Select Between YES/NO.\n)Attempt Left{attempt}");
                }
                switch(UserChoice)
                {
                    case "YES":
                        //IsGuest = true;
                        UserCart();
                        break;
                    case "NO":
                        Console.WriteLine("Thanks for Visting C# Fruit Basket. Have nice day Ahead");
                        return;
                }

            }
            else //for staff == Yes
            {
                int PIN = 2025;
                Console.WriteLine($"Hello {UserName} Please Enter Pin to Proceed");
                while (attempt > 0)
                {
                    String CPIN = Console.ReadLine() ?? "0";
                    int i = 0;
                    bool valid = int.TryParse(CPIN, out i);
                    if (valid)
                    {
                        while (PIN != i && attempt != 0)
                        {
                            Console.WriteLine("Invalid PIN. Please Try Again. Attempt Left:{0}", attempt);
                            //Handel invalid integer logic
                            i = int.Parse(Console.ReadLine() ?? "0");
                            attempt--;

                        }
                        if (i == PIN)
                        {
                            int AdminOption = 1;
                            while (AdminOption >= 1 && AdminOption <= 3)
                            {
                                Console.WriteLine("Please select Option to Proceed.\n1. Update Existing Item.\n2. Add an Item\n3. Remove an Item.\n0. To Logout and Exit for New User.");
                                AdminOption = int.Parse(Console.ReadLine() ?? "0");
                                switch (AdminOption)
                                {
                                    case 1: //Updating Existing Item
                                        double UpdatedPrice = 0;
                                        Console.WriteLine("Current Menu is");
                                        Menu();
                                        Console.WriteLine("Select the S.No. of Item You Want to Update");
                                        int UpdateFruit = int.Parse(Console.ReadLine() ?? "0");
                                        if (UpdateFruit == 0 || UpdateFruit > Fruits.Count)
                                        {
                                            Console.WriteLine("Invalid Option");
                                        }
                                        else
                                        {
                                            UpdateFruit--;
                                            Console.WriteLine("Enter New Name For {0}. Or Press Enter for NO Change in fruit Name", Fruits[UpdateFruit]);
                                            string OldFruitName = Fruits[UpdateFruit];
                                            string NewFruitName = Console.ReadLine() ?? OldFruitName;
                                            NewFruitName = NewFruitName.ToUpper();

                                            if (Fruits.Contains(NewFruitName))
                                            {
                                                Console.WriteLine($"{NewFruitName} is Already in Menu at S. No. {UpdateFruit + 1}");
                                            }
                                            Fruits[UpdateFruit] = NewFruitName;
                                            Console.WriteLine($"Enter Price for the {NewFruitName} :");
                                            double OldPrice = Price[UpdateFruit];
                                            string Up = Console.ReadLine() ?? "0"; //Up is for update Price
                                            bool Up2 = double.TryParse(Up, out UpdatedPrice);
                                            if (Up2)
                                            {
                                                Price[UpdateFruit] = UpdatedPrice;
                                                if (OldFruitName != NewFruitName && OldPrice != UpdatedPrice)
                                                {
                                                    Console.WriteLine($"Hello {UserName}, You have updated {OldFruitName} to {NewFruitName} and its Price from {OldPrice} to {UpdatedPrice}.\nMenu Updated Successfully");
                                                }
                                                else if (OldFruitName != NewFruitName && OldPrice == UpdatedPrice)
                                                {
                                                    Console.WriteLine($"Hello {UserName}, You have updated {OldFruitName} to {NewFruitName}.\nMenu Updated Successfully");
                                                }
                                                else if (OldFruitName == NewFruitName && OldPrice != UpdatedPrice)
                                                {
                                                    Console.WriteLine($"Hello {UserName}, You have updated Price of {OldFruitName} from {OldPrice} to {UpdatedPrice}.\nMenu Updated Successfully");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Nothing To Updated\nMenu is unchanged");
                                                }
                                            }

                                        }
                                        break;
                                    case 2: //Adding An Item to Fruit List
                                        Console.WriteLine($"Hello {UserName}, Please Enter Fruit to Your Menu");
                                        string NewFruit = Console.ReadLine() ?? "0";
                                        double NewFruitPrice = 0;
                                        if (NewFruit == "0")
                                        {
                                            Console.WriteLine("No Fruit Name Entred");
                                        }
                                        else
                                        {
                                            NewFruit = NewFruit.ToUpper();
                                            Console.WriteLine($"Enter Price for {NewFruit}:");
                                            string NFP = Console.ReadLine() ?? "Empty"; //NFP is New Fruit Price
                                            bool NFP2 = double.TryParse(NFP, out NewFruitPrice);
                                            if (NFP2)
                                            {
                                                Fruits.Add(NewFruit);
                                                Price.Add(NewFruitPrice);
                                                Console.WriteLine($"{NewFruit} with Price {NewFruitPrice} is added to Menu Successfully");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid Price Entered. No Change In Menu");
                                            }

                                        }
                                        break;
                                    case 3: //Removing Item from Fruit List
                                        Console.WriteLine("Please Select Fruit's S.no. from Menu");
                                        Menu();
                                        int RemoveItemSNo = 0;
                                        string RI = Console.ReadLine() ?? "0";
                                        bool RI2 = int.TryParse(RI, out RemoveItemSNo);
                                        if (RI2)
                                        {
                                            RemoveItemSNo--;
                                            if (RemoveItemSNo >= 0 && RemoveItemSNo <= Fruits.Count)
                                            {
                                                String RemFruit = Fruits[RemoveItemSNo - 1];
                                                Fruits.RemoveAt(RemoveItemSNo - 1);
                                                Price.RemoveAt(RemoveItemSNo - 1);
                                                Console.WriteLine($"{RemFruit} is Removed from Menu Successfully");
                                            }
                                        }

                                        break;

                                }
                                Menu();

                            }
                        }
                        else
                        {
                            Console.WriteLine("Sorry We Are Under Maintenance Now. Please Visit Us Later.");
                        }
                    }
                    else  //For Invalid Pin Format other than int value
                    {
                        Console.WriteLine("Invalid PIN Format");
                        attempt--;
                    }
                }
            }
            UserCart();

        }

    }
}