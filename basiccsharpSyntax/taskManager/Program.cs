// add tasks
// view tasks on the list
// mark tasks as completed

using System.Transactions;

class taskManager {
    public class ToDoList{
        // array to hold up to ten tasks
        public static string[] tasks = new string[10];
        public static int taskCount = 0;

        public static void AddTask() {
            Console.WriteLine("Enter a new task: ");
            tasks[0] = Console.ReadLine();
            taskCount++;
        }
        public static void ViewTasks(){
            for (taskCount = 0; taskCount <= tasks.Length; taskCount++){
                Console.WriteLine(taskCount++ + ". " + tasks[taskCount]);
            }
        }

        public static void CompleteTask() {
            Console.WriteLine("Enter the number of task to mark as complete:");
            int taskNumber = int.Parse(Console.ReadLine()) - 1 ;

            if (taskNumber >= 0 && taskNumber < taskCount){
                tasks[taskNumber] = ;
            }
            else{
                Console.WriteLine("Enter a vaild task");
            }
        }
    }

    public static void Main(string[] args) {

    }
}