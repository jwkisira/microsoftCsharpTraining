public class Program{
    public static void Main(string[] args){
        // program that checks if numbers in it are even or odd
        int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        for(int i = 0; i < numbers.Length; i++){
            if (numbers[i] % 2 == 0){
                Console.WriteLine(numbers[i]+ " is even");
            }
            else{
                Console.WriteLine(numbers[i] + " is odd");
            }
        }
    }
}