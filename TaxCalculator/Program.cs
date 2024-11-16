// app that calculates tax rates based on income whether one is a resident, or not
// if income is less that 50,000, resident's tax is 10% and non resident's tax is 15%
// if income is between 50,000 and 100,000, resident's tax is 20% and non residents' tax is 25%
// if income is over 100k, resident's tax is 30% and non resident's is 35%

// this app accounts for only residents

public class TaxCalculator {
    public static void calculateTax(){
        int income;
        int tax;
        Boolean isResident = true;
        

        Console.WriteLine("Enter your monthly income:");
        income = int.Parse(Console.ReadLine());

        if (income < 50000){
            if (isResident){
                tax = income - (income*10/100);
                Console.WriteLine("Your income after tax is: "+ tax);
            }
            else{
                tax = income - (income*15/100);
                Console.WriteLine("Your income after tax is: "+ tax);
            }
        }
        else if (income >= 50000 && income <= 100000){
            if (isResident){
                tax = income - (income*20/100);
                Console.WriteLine("Your income after tax is: "+ tax);
            }
            else{
                tax = income - (income*25/100);
                Console.WriteLine("Your income after tax is: "+ tax);
            }
        }
        else{
            if (isResident){
                tax = income - (income*30/100);
                Console.WriteLine("Your income after tax is: "+ tax);
            }
            else{
                tax = income - (income*35/100);
                Console.WriteLine("Your income after tax is: "+ tax);
            }
        }
    }

    public static void Main(String[] args){
        calculateTax();
    }
}