// program that assigns membership based on age and choice


public class GymMembership {
    public static void Main(string[] args){
        int age;
        Console.WriteLine("Enter your age:");
        age = int.Parse(Console.ReadLine());

        // ask them if they want a basic or premium membership and store their input
        string? choice;
        Console.WriteLine("Do you want premium membership(Yes/no)?");
        choice = Console.ReadLine();
        bool isPremium = choice.ToLower() == "yes";

        double Price;
        string Plan;

        // evaluate their input for age and choice and assign appropriately
        if (age < 18){
            if (isPremium){
                Price = 15;
                Plan = "Basic";
                Console.WriteLine("Basic Plan price is "+ Price);
            }
            else{
                Price = 25;
                Plan = "Premium";
                Console.WriteLine("Premium Plan Price is " + Price);
            }
        }
        else if (age >= 18 && age <= 60){
            if (isPremium){
                Price = 30;
                Plan = "Basic";
                Console.WriteLine("Basic Plan price is "+ Price);
            }
            else{
                Price = 50;
                Plan = "Premium";
                Console.WriteLine("Premium Plan Price is " + Price);
            }
        }
        else {
            if (isPremium){
                Price = 20;
                Plan = "Basic";
                Console.WriteLine("Basic Plan price is "+ Price);
            }
            else{
                Price = 35;
                Plan = "Premium";
                Console.WriteLine("Premium Plan Price is " + Price);
            }
        }
    }
}