public class Greeting{

    public static void greet(){
        // prompt the user to enter their name

        Console.WriteLine("Enter your name ");
        string name = Console.ReadLine();

        // greet customer
        Console.WriteLine("Hello, " + name);
    }

    public static void Main(string[] args){
        greet();
    }
}