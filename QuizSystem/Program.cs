using System.Globalization;

class Program{
    public static void Main(string[] args){
        int[] scores = {85, 90, 78, 92, 88};

        int scoresTotal = 0;
        // loop to iterate over each element of the array
        for (int i = 0; i<scores.Length; i++){
            // statement to calclulate the total score
            scoresTotal = scoresTotal + scores[i];
        }
        Console.WriteLine(scoresTotal);
    }
}