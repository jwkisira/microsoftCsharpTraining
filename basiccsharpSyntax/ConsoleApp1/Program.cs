using Pastel;

class Program {
    // function that takes 2 vars and prints out the sum
    // basically a calculator
    public static int sumOfNumbers(int a, int b){
        return a + b;
    }

    static void Main(string[] args){
        int numb1 = 10;
        int numb2 = 5;

        Console.WriteLine(sumOfNumbers(numb1, numb2));
    }
}