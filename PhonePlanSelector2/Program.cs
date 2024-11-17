public class PhonePlanSelector2 {
    public static void Main(string[] args){
        int dataNeeds;
        Console.WriteLine("Enter desired data plan: \n2GB(no international calls) - Basic Plan\n 5GB(no international calls) - Standard Plan\n 10GB(no international calls) - Standard-Premium Plan\n 10GB(with international calls) - Premium Plan\n Unlimited Plan(With international calls) - Deluxe Plan:");
        dataNeeds = int.Parse(Console.ReadLine());

        string? intlCallsInput;
        Console.WriteLine("Do you want international calls? (yes/no)");
        intlCallsInput = Console.ReadLine();
        bool wantsIntlCalls = intlCallsInput.ToLower() == "yes";

        string plan = "";

        switch(dataNeeds){
            case 2:
                plan = "Basic Plan";
                Console.WriteLine(plan);
                break;
            case 5:
                plan = "Standard Plan";
                Console.WriteLine(plan);
                break;
            case 10:
                if (wantsIntlCalls){
                    plan = "Premium Plan with international calls";
                    Console.WriteLine(plan);
                }
                else{
                    plan = "Standard plan";
                    Console.WriteLine(plan);
                }
                break;
            case -1:
                plan = "Unlimited Plan with international calls";
                Console.WriteLine(plan);
                break;
            default:
                plan = "Invalid data request";
                break;
        }
    }
}