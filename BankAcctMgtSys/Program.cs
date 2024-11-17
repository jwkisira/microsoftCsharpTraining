// bank acct mgt system that manages different types of accounts and applies correct fees or interest rates based on type

public class BankAcctMgtSys {
    public static void Main(string[] args){
        int accountType;
        Console.WriteLine("Input the account type:\n 1. Savings Account\n 2. Checking Account\n 3. Business Account");
        accountType = int.Parse(Console.ReadLine());

        double AccountBalance;
        Console.WriteLine("Enter your account balance Here");
        AccountBalance = Convert.ToDouble(Console.ReadLine());

        double interestRate = 0;
        double monthlyFee;

        switch (accountType){
            case 1:
                interestRate = 0.02;
                Console.WriteLine("Your interest rate is " + interestRate);
                break;
            case 2:
                interestRate = 0.10;
                Console.WriteLine("Your interest rate is " + interestRate);
                break;
            case 3:
                interestRate = 0.01;
                monthlyFee = 20;
                Console.WriteLine("Your monthly fee is "+ monthlyFee + " and interest rate is " + interestRate );
                break;
            default:
                Console.WriteLine("Invalid Input");
                break;
        }
        double balanceAfterIR = AccountBalance + (AccountBalance / interestRate);

        if (accountType == 3){
            Console.WriteLine("Your new account Balance: "+ balanceAfterIR+ " and your monthly fee is 20%");
        }
        else{
            if (accountType <= 4){
                Console.WriteLine("Invalid input");
            }
            else{
                Console.WriteLine("Your new account Balance: "+ balanceAfterIR);
            }
        }
    }
}