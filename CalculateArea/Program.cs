// program that calculates area of a rectangle based on the input of the user

using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;

public class Program{
    // function to handle area of rectangle
    public static void calculateArea(int length, int width){
        Console.WriteLine("length: ");
        length = int.Parse(Console.ReadLine());

        Console.WriteLine("width: ");
        width = int.Parse(Console.ReadLine());

        int area = length * width;

        Console.WriteLine(area);
        // return;
    }

    // function to handle area of triangle
    public static void calculateTriangleArea(double b, double h){
        Console.WriteLine("base:");
        double base1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("height:");
        double height = Convert.ToDouble(Console.ReadLine());

        double triangleArea = 0.5 * base1 * height; 

        Console.WriteLine("Area of triangle = "+triangleArea);
    }

    
    public static void Main(string[] args){
        Console.WriteLine("Area of :\n 1.Triangle \n 2. Rectangle ");
        int choice = int.Parse(Console.ReadLine());

        switch(choice){
            case 1:
                calculateTriangleArea(2, 3);
                break;
            case 2:
                calculateArea(1, 2);
                break;
            default:
                Console.WriteLine("invalid input");
                break;
        }
    }
}