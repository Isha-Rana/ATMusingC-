using System;
public class cardHolder
{
    String cardNum;
    int pin;
    String firstName;
    String lastName;
    double balance;
    public cardHolder(string cardNum, int pin, string firstName, String lastName,double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = 0;
    }
    public void setNum(String newcardNum)
    {
        cardNum = newcardNum;
    }
    public String getCardNum()
    {
        return cardNum;
    }
    public void setPin(int newPin)
    {
        pin=newPin;
    }
    public int getPin()
    {
        return pin;
    }
    public void setfirstName(String newfirstName)
    {
        firstName = newfirstName;
    }
    public String getfirstName()
    {
        return firstName;
    }
    public void setlastName(String newlastName)
    {
        lastName = newlastName;
    }
    public String getlastName()
    {
        return lastName;
    }
    public void setbalance(double newbalance)
    {
        balance = newbalance;
    }
    public double getBalance()
    {
        return balance;
    }
    public static void Main(String[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Please choose from the following options: ");
            Console.WriteLine("1.deposit");
            Console.WriteLine("2.withdraw");
            Console.WriteLine("3.show balance");
            Console.WriteLine("4.exit");
        }
        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("Please choose $$ would you like to deposit??");
            double deposit=Double.Parse(Console.ReadLine());
            double isha = deposit + currentUser.getBalance();
            currentUser.setbalance(isha);
            Console.WriteLine("thank you for your $$. your new balance is:" + currentUser.getBalance());
        
        
        }
        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much cash you want to withdraw??");
            double withdrawl=Double.Parse(Console.ReadLine());
            if (withdrawl > currentUser.getBalance())
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                currentUser.setbalance(currentUser.getBalance() - withdrawl);
                Console.WriteLine("thank you!1 you are good to go the cash have been withdrawn.");
            }
        }
        void balance(cardHolder currentUser)
        {
            Console.WriteLine("balance of your account is:" + currentUser.getBalance());
        }
        
        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("456780899990", 1234, "John", "Griffith", 150.31));
        cardHolders.Add(new cardHolder("456780899991", 2341, "isha", "rana", 156.31));
        cardHolders.Add(new cardHolder("456780899992", 5674, "yash", "singh", 360.31));
        cardHolders.Add(new cardHolder("456780899993", 7890, "ayush", "maan", 780.56));
        cardHolders.Add(new cardHolder("456780899994", 4567, "golu", "Gloluh", 157.31));

        Console.WriteLine("Welcome to the ATM");
        Console.WriteLine("Please inert your debit card: ");
        String debitCardNum = "";
        cardHolder currentUser;
        while (true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                //check against our db
                currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
                if (currentUser != null) { break; }
                else { Console.WriteLine("Card not recognized. Please try again"); }
            }
            catch { Console.WriteLine("card not recognized. Please try again"); }
        }
        Console.WriteLine("Pkease enter your pin:");
        int userPin = 0;
        while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());
                //check against our db
                currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
                if (currentUser.getPin() == userPin) { break; }
                else { Console.WriteLine("Incorrect Pin. Please try again"); }
            }
            catch { Console.WriteLine("Incorrect Pin. Please try again"); }
        }
        Console.WriteLine("Welcome" + currentUser.getFirstName() + ":)");
        int option = 0;
        do
        {
            printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch { }
            if (option == 1) { deposit(currentUser); }
            else if (option == 2)
            {
                withdraw(currentUser);
            }
            else if (option == 3)
            {
                balance(currentUser);
            }
            else if (option == 4)
            {
                break;
            }
            else
            {
                option = 0;
            }
        } while (option != 4);
        Console.WriteLine("Thank you ! have a nice day!!");
    }
};
