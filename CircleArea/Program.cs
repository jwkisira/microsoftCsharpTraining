// program to calculate area of circle pie*r^2

using System.Globalization;
using System.Net.NetworkInformation;

public class Program{
    public static double circleArea(double radius){
        return Math.PI * (radius * radius);
    }

    public static void Main(){
        // prompt user for radius
        Console.WriteLine("Enter your radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        // call area function
        Console.WriteLine("area of your circle is : " + circleArea(radius));
    }
}