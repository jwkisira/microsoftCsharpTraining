public class Program{
    public static void Main(string[] args){
        // program that uses for and switch to assign letter grades based on score
        int[] studentGrades = {18, 93, 82, 44, 68, 72, 86};

        for (int i = 0; i < studentGrades.Length; i++){
            int grades = studentGrades[i];
            switch (grades){
                case int n when(n >= 90):
                    Console.WriteLine(n + " - Grade A: GREAT JOB");
                    break;
                case int n when(n >= 80):
                    Console.WriteLine(n + " - Grade B: GOOD JOB");
                    break;
                case int n when(n >= 70):
                    Console.WriteLine(n + " - Grade C: FAIR JOB");
                    break;
                case int n when(n >= 60):
                    Console.WriteLine(n + " - Grade D: ROOM FOR IMPROVEMENT AHH JOB");
                    break;
                default:
                    Console.WriteLine("F - Failed in so much that we cannot show you the grade... pull up your socks mate!");
                    break;
            }
        } 
    }
}