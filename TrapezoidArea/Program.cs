// program to calculate area of trapezoid

public class TrapezoidArea{
    public static double areaOfTrapezoid(double s1, double s2, double height){
        return (s1 + s2) / 2 * height;
    }

    public static void Main(){
        // prompt user for side 1
        Console.WriteLine("Enter length of one side:");
        double side1 = Convert.ToDouble(Console.ReadLine());

        // prompt user for side 2
        Console.WriteLine("Enter length of side 2:");
        double side2 = Convert.ToDouble(Console.ReadLine());

        // prompt user for height
        Console.WriteLine("Enter the height:");
        double height = Convert.ToDouble(Console.ReadLine());

        // funciton call
        Console.WriteLine("area of trapezoid = "+ areaOfTrapezoid(side1, side2, height));
    }
}