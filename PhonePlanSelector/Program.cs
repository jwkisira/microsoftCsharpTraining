// app that allows users to choose a phone plan based on data they want
// and whether they need international calling
// available plans; 
//  - basic plan = 2GB data, no international calling
//  - Standard = 5gb data, no international callling
//  - Premium = 10gb data, international calling
//  - elite = unlimited, international calling 

using System.Diagnostics;

class DataPlans {
    public static void ChoosePlan(){
        int planChoice;

        Console.WriteLine("Choose a data plan;\n 1. Basic\n 2. Standard\n 3. Premium\n 4. Elite");
        planChoice = int.Parse(Console.ReadLine());

        switch (planChoice){
            case 1:
            case 2:
                Console.WriteLine("Success: data without international calls");
                break;
            
            case 3:
            case 4:
                Console.WriteLine("Success: data and international calls");
                break;
            default:
                Console.WriteLine("Invalid choice, choose betweeen option one and 4");
                break;
        }
    }

    public static void Main(string[] args){
        ChoosePlan();
    }
}