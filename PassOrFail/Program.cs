﻿// determine if a student's scores pass or fail

class Program{
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
    }
}