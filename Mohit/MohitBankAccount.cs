using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohit
{
    public class MohitBankAccount  //Bank Account Class(Encapsulation Example)
    {
        private double _balanece;
        private string name;
        private int accnumber;
        private string acctype;

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
        public double Balance
        {
            get { return _balanece; }
            private set 
            {
                if (value < 0)
                {
                    Console.WriteLine("Balance cannot be negative.");
                    _balanece = 0;
                }
                else
                {
                    _balanece = value;
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

        public static void BankingApp() //This is Main Class of this Code
        {
            MohitBankAccount[] accounts = new MohitBankAccount[5];  //Creating Array of 5 Bank Accounts
            accounts[0] = new MohitBankAccount() { AccountNumber = 1011, AccountHolderName = "Mohit Kumar", AccountType = "Salried", Balance = 50000 };
            accounts[1] = new MohitBankAccount() { AccountNumber = 1012, AccountHolderName = "Ankit Kumar", AccountType = "Business", Balance = 50000 };
            accounts[2] = new MohitBankAccount() { AccountNumber = 1013, AccountHolderName = "Rohit Sharma", AccountType = "Salried", Balance = 50000 };
            accounts[3] = new MohitBankAccount() { AccountNumber = 1014, AccountHolderName = "Suresh Raina", AccountType = "Business", Balance = 50000 };
            accounts[4] = new MohitBankAccount() { AccountNumber = 1015, AccountHolderName = "Virat Kohli", AccountType = "Salried", Balance = 50000 };

            string Wish = Greet.Hello();  //Calling Greet Class to get Wish Message
            Console.WriteLine("Welcome to Mohit Bank!");
            Console.Write("Enter your Account Number: ");
            string accNumInput = Console.ReadLine() ?? string.Empty;
            int AN = MohitConvertDataType.StringToInt(accNumInput); //Converting String to Int using MohitConvertDataType Class

            MohitBankAccount UserAccount = null;  //Finding User Account

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
                Console.WriteLine("Account not found. Exiting application.");
                return;
            }
            Console.WriteLine($"{Wish}, {UserAccount.AccountHolderName}!"); //Greeting and Displaying Found User
            Console.WriteLine($"Your current balance is: {UserAccount.Balance}");
            Console.WriteLine($"Your Account Type is: {UserAccount.AccountType}");

            Console.WriteLine("Please Select Transaction Type \n1 for Deposit\n2 for Withdraw\n3 for Calculate Intrest On Fixed deposit with Us");  //Asking User for Transaction Type
            int choice = MohitConvertDataType.StringToInt(Console.ReadLine() ?? string.Empty);

            switch (choice)  //Performing Transaction based on User Choice
            {
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
                    Console.WriteLine("Please Enter Time in Years for which You want to Calculate Intrest: ");
                    String Time = Console.ReadLine() ?? string.Empty;
                    double TimePeriod = MohitConvertDataType.StringToDoub(Time);
                    //Console.WriteLine("Please Enter Provided Rate of Intrest for which You want to Calculate Intrest: ");
                    //String ROI = Console.ReadLine() ?? string.Empty;
                    double RateOfIntrest = 7.5;
                    MohitMath.CompoundInt(Principal, TimePeriod, RateOfIntrest, out double Amount, out double Intrest);
                    Console.WriteLine($"{Wish} {UserAccount.AccountHolderName}, For Your Amount {Principal}, if you deposit for {TimePeriod} Years at Rate of Intrest of {RateOfIntrest}.");
                    Console.WriteLine($"You will get Total Amont of Rs. {Amount:F2}");
                    Console.WriteLine($"You Will Earn Intrest of Rs. {Intrest:F2}");
                    break;

                default:
                    Console.WriteLine($"{Wish} {UserAccount.AccountHolderName}, Invalid choice. Exiting application.");
                    break;


            }

        }


    }
}
