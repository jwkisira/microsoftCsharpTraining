// program that asks users for input, number between 1 and 10 that is even

int input;
Console.WriteLine("Enter a number between 1 and 10:");
input = int.Parse(Console.ReadLine());

do {
    if (input > 0 && input <= 10 && input%2 == 0){
        Console.WriteLine("success: "+ input+ " is and even number");
        break;
    }
    else{
        Console.WriteLine("Invalid input, please try again");
        break;
    }
}while(true);