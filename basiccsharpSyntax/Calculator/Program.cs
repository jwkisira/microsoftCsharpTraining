public class Calculator{

    public static int number1;
    public static int number2;

    public static int Add(int a, int b){
        number1 = a;
        number2 = b;
        return number1 + number2;
    }

    public static void Main (){
        number1 = 5;
        number2 = 6;

        int result = Add(number1, number2);

        Console.WriteLine("The sum of the values is: " + result);
    }
}