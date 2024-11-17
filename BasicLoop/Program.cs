// program that calculates values in an array using for loops

using System.Diagnostics.Metrics;

int[] numbers = {1, 2, 3, 4, 5};

int sum = 0;

for(int i = 0; i < numbers.Length; i++){
    sum = sum + numbers[i];
}

Console.WriteLine(sum);


// program that uses while loops

string? execute = "";

while (execute != "exit"){
    Console.WriteLine("Enter your input(type 'exit' to terminate):");
    execute = Console.ReadLine();
}


// program that uses do while loops
int counter = 0;
do{
    if (counter >= 10){
        Console.WriteLine("Counter is greater than or equal to 10");
    }
    else{
        Console.WriteLine(counter);
    }
    counter++;
}while (counter<10);