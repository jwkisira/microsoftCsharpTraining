public class Program{
    public static void Main(string[] args){
        // program that uses for and switch to assign letter grades based on score
        int[] studentGrades = {18, 93, 82, 44, 68, 72, 86};

        for (int i = 0; i < studentGrades.Length; i++){
            switch (studentGrades[i]){
                case int n when(studentGrades[i] >= 90):
                    Console.WriteLine(studentGrades[i] + " - Grade A: GREAT JOB");
                    break;
                case int n when(studentGrades[i] >= 80):
                    Console.WriteLine(studentGrades[i] + " - Grade B: GOOD JOB");
                    break;
                case int n when(studentGrades[i] >= 70):
                    Console.WriteLine(studentGrades[i] + " - Grade C: FAIR JOB");
                    break;
                case int n when(studentGrades[i] >= 60):
                    Console.WriteLine(studentGrades[i] + " - Grade D: ROOM FOR IMPROVEMENT AHH JOB");
                    break;
                default:
                    Console.WriteLine("F - Failed in so much that we cannot show you the grade... pull up your socks");
                    break;
            }
        } 
    }
}