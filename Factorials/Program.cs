class Program {
    public static void Main(string[] args){
        int number = 5;

        int factorial = 0;

        while (number > 1){
            factorial = number * number - 1;
            number--;
        }
        Console.WriteLine(factorial);
    }
}