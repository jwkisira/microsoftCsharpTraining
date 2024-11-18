public class Program{
    public static void Main(){
        // program that evaluates a list of student grades and determines if they passed or failed
        int[] grades = {82, 45, 66, 81, 89};

        for (int i = 0; i < grades.Length; i++){
            if (grades[i] >= 65){
                Console.WriteLine(grades[i]+" - pass");
            }
            else{
                Console.WriteLine(grades[i]+ " - fail");
            }
        }
    }
}