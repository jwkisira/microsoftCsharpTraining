// program to determine ticket price based on passenger's age
// children under 12 pay half price
// adults 12 to 65 pay full price
// seniors over 65 get 20% discount

public class Tickets{
    public static void determinePrice(){
        int age;

        Console.WriteLine("Enter your age: ");
        age = int.Parse(Console.ReadLine());

        if (age < 12) {
            Console.WriteLine("Half price ticket");
        } else if (age > 12 && age < 65) {
            Console.WriteLine("Full price ticket");
        } else {
            Console.WriteLine("Senior discount ticket");
        }
    }

    public static void Main(String[] args){
        determinePrice();
    }
}