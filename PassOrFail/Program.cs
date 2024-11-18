// determine if a student's scores pass or fail

class Program{
    public static void evaluateGrade(){
        // function iterates through list of student's grades and assigns approprate message
        // using when and switch cases
        int[] grades = {23, 56, 75, 18, 83, 89};

        for (int i = 0; i < grades.Length; i++){
            int grade = grades[i];
            switch (grade){
                case int n when (n > 90):
                    Console.WriteLine("Excellent");
                    break;
                case int n when (n > 80):
                    Console.WriteLine("Good job");
                    break;
                case int n when (n > 70):
                    Console.WriteLine("Fairs");
                    break;
                case int n when (n > 60):
                    Console.WriteLine("Needs improvement");
                    break;
                default:
                    Console.WriteLine("Fail");
                    break;
            }
        }
    }


    public static void Main(string[] args){
        int[] studentScores = {45, 60, 72, 38, 55};

        for(int i = 0; i < studentScores.Length; i++){
            if (studentScores[i] > 50){
                Console.WriteLine(studentScores[i] + " - Pass");
            }
            else{
                Console.WriteLine(studentScores[i] + " - Fail");
            }
        }

        evaluateGrade();
    }
}