using System;
using Mohit;
using Mohit.Mohit_Misc;
namespace Mohit
{
    public class MohitBankAccount  //Bank Account Class(Encapsulation Example)
    {
        private double _balance;
        private string? name;
        private int accnumber;
        private string? acctype;
        private int pin;
       

        // ---------- Public Getters and Setters ----------
        public string AccountHolderName
        {
            get { return name; }
            set { name = value; }
        }
        public int AccountNumber
        {
            get { return accnumber; }
            set { accnumber = value; }
        }
        public string AccountType
        {
            get { return acctype; }
            set { acctype = value; }
        }
        public int PIN
        {
            get { return pin; }
            set { pin = value; }
        }
        public double Balance
        {
            get { return _balance; }
            private set 
            {
                if (value < 0)
                {
                    Console.WriteLine("Balance cannot be negative.");
                    _balance = 0;
                }
                else
                {
                    _balance = value;
                }
            }
        }
       public void Deposit(double amount)  //Code for Deposit Method
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }
            Balance += amount;
            Console.WriteLine($"Deposited: {amount}. New Balance: {Balance}");
        }
        public void Withdraw(double amount)   //Code for Withdraw Method
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return;
            }
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds for this withdrawal.");
                return;
            }
            Balance -= amount;
            Console.WriteLine($"Withdrew: {amount}. New Balance: {Balance}");
        }
        public void UpdatePIN(int oldPIN, int newPIN)  //Code for Update PIN Method
        {
            if (oldPIN != PIN)
            {
                Console.WriteLine("Old PIN is incorrect.");
                return;
            }
            PIN = newPIN;
            //Console.WriteLine("PIN updated successfully.");
        }

        public static void BankingApp() //This is Main Class of this Code
        {
            MohitConvertDataType MohitConvertDataType = new MohitConvertDataType();
            //FixedDepositC
            MohitBankAccount[] accounts = new MohitBankAccount[5];  //Creating Array of 5 Bank Accounts
            accounts[0] = new MohitBankAccount() { AccountNumber = 1011, AccountHolderName = "Mohit Kumar", AccountType = "Salried", Balance = 50000, PIN = 1011 };
            accounts[1] = new MohitBankAccount() { AccountNumber = 1012, AccountHolderName = "Ankit Jain", AccountType = "Business", Balance = 50000, PIN = 1012 };
            accounts[2] = new MohitBankAccount() { AccountNumber = 1013, AccountHolderName = "Vani Sharma", AccountType = "Salried", Balance = 50000, PIN = 1013 };
            accounts[3] = new MohitBankAccount() { AccountNumber = 1014, AccountHolderName = "Anuj Raina", AccountType = "Business", Balance = 50000, PIN = 1014 };
            accounts[4] = new MohitBankAccount() { AccountNumber = 1015, AccountHolderName = "Tripti Bhatnagar", AccountType = "Salried", Balance = 50000, PIN = 1015 };

            string Wish = Greet.Hello();  //Calling Greet Class to get Wish Message
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to Mohit Bank!");
            Console.Write("Enter your Account Number: ");
            string accNumInput = Console.ReadLine() ?? string.Empty;
            int AN = MohitConvertDataType.StringToInt(accNumInput); //Converting String to Int using MohitConvertDataType Class

            MohitBankAccount? UserAccount = null;  //Finding User Account

            foreach (var an in accounts)
            {
                if (an.AccountNumber == AN)
                {
                    UserAccount = an;
                    break;
                }
            }
            if (UserAccount == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Account not found. Exiting application.");
                return;
            }
            Console.WriteLine($"{Wish}, {UserAccount.AccountHolderName}!"); //Greeting and Displaying Found User
            int attempt = 3;
            string UserDecsion = "Y";
            void VerifyPIN()
            {
                while (attempt > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Please Enter your PIN to Continue");
                    string pinInput = Console.ReadLine() ?? string.Empty;

                    int enteredPIN = MohitConvertDataType.StringToInt(pinInput);

                    if (enteredPIN == UserAccount.PIN)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("PIN Verified Successfully!");
                        return;
                    }
                    else
                    {
                        attempt--;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Incorrect PIN. Attempts left: {attempt}");
                    }
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Too many incorrect attempts. Exiting application.");
                Console.ForegroundColor = ConsoleColor.White;
                Environment.Exit(0);
            }

            VerifyPIN(); //Calling Verify PIN Method
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Thankyou {UserAccount.AccountHolderName} for Verifying. Your Accounnt number is {UserAccount.AccountNumber}");
            Console.WriteLine($"Your current balance is: {UserAccount.Balance}");
            Console.WriteLine($"Your Account Type is: {UserAccount.AccountType}");
            int choice = 5;
            BankingOperation(); //Calling Banking Operation Method
            void BankingOperation() //Banking Operation Method
            {
                if (UserDecsion.ToUpper() != "Y" || choice ==0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Exiting application. Thank you for banking with us!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Environment.Exit(0);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Please Select Transaction Type\n0 To Exit \n1 for Deposit\n2 for Withdraw\n3 for Calculate Intrest On Fixed deposit with Us\n4 for Updating your PIN");  //Asking User for Transaction Type
                    choice = MohitConvertDataType.StringToInt(Console.ReadLine() ?? string.Empty);
                    attempt = 3; //Resetting PIN Attempts for Next Transaction

                    switch (choice)  //Performing Transaction based on User Choice
                    {
                        case 0:
                            Console.WriteLine("Exiting application. Thank you for banking with us!");
                            Environment.Exit(0);
                            break;
                        case 1:
                            Console.WriteLine("Enter amount to Deposit:");
                            double depAmount = MohitConvertDataType.StringToDoub(Console.ReadLine() ?? string.Empty);
                            UserAccount.Deposit(depAmount);
                            break;
                        case 2:
                            Console.WriteLine("Enter amount to Withdraw:");
                            double withAmount = MohitConvertDataType.StringToDoub(Console.ReadLine() ?? string.Empty);
                            UserAccount.Withdraw(withAmount);
                            break;
                        case 3:
                            Console.WriteLine("Please Enter Principal Amount which you want to deposit: ");
                            String Pri = Console.ReadLine() ?? string.Empty;
                            double Principal = MohitConvertDataType.StringToDoub(Pri);
                            Console.WriteLine("Continuing with us will implement the Rate of intrest for 7.5% irrespective of the time period.");
                            Console.WriteLine("We Partnered with Other banks for the Fixed Deposit");
                            Console.WriteLine("SBI 8%");
                            Console.WriteLine("HDFC 9%");
                            BankMenu bankMenu = new BankMenu();
                            InterestResult bankResult = bankMenu.ShowMenu();   
                            double RateOfIntrest = bankResult.ROI;
                            double TimePeriod = bankResult.Period;
                            //Console.WriteLine("Please Enter Time in Years for which You want to Calculate Intrest: ");
                            //String Time = Console.ReadLine() ?? string.Empty;
                            //double TimePeriod = MohitConvertDataType.StringToDoub(Time);
                            //Console.WriteLine("Please Enter Provided Rate of Intrest for which You want to Calculate Intrest: ");
                            //String ROI = Console.ReadLine() ?? string.Empty;
                            //double RateOfIntrest = 7.5;
                            MohitMath.CompoundInt(Principal, TimePeriod, RateOfIntrest, out double Amount, out double Intrest);
                            Console.WriteLine($"{Wish} {UserAccount.AccountHolderName}, For Your Amount {Principal}, if you deposit for {TimePeriod} Years at Rate of Intrest of {RateOfIntrest}.");
                            Console.WriteLine($"You will get Total Amont of Rs. {Amount:F2}");
                            Console.WriteLine($"You Will Earn Intrest of Rs. {Intrest:F2}");
                            break;
                        case 4:
                            Console.WriteLine("Enter your Old PIN:");
                            int oldPIN = MohitConvertDataType.StringToInt(Console.ReadLine() ?? string.Empty);
                            Console.WriteLine("Enter your New PIN:");
                            int newPIN = MohitConvertDataType.StringToInt(Console.ReadLine() ?? string.Empty);
                            UserAccount.UpdatePIN(oldPIN, newPIN);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("PIN Updated Successfully");
                            break;


                        default:
                            Console.WriteLine($"{Wish} {UserAccount.AccountHolderName}, Invalid choice. Please Try Again");
                            break;


                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You Need to Verify PIN Again to Perform Another Transaction");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Do you want to perform another transaction? (Y/N): ");
                    UserDecsion = Console.ReadLine() ?? string.Empty;
                    if (string.IsNullOrWhiteSpace(UserDecsion))
                        UserDecsion = "N";
                    else
                        UserDecsion = UserDecsion.Trim().Substring(0, 1).ToUpper();
                    VerifyPIN();
                    BankingOperation();
                }
            }
            

        }


    }
}
