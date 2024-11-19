// program that calculates area of a rectangle based on the input of the user

using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;

public class Program{
    // function to handle calculations
    public static void calculateArea(int length, int width){
        Console.WriteLine("length: ");
        length = int.Parse(Console.ReadLine());

        Console.WriteLine("width: ");
        width = int.Parse(Console.ReadLine());

        int area = length * width;

        Console.WriteLine(area);
        // return;
    }

    public static void Main(string[] args){
        calculateArea(10, 5);
    }
}