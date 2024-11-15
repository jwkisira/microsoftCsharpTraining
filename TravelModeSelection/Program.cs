// a program that offers multiple travel modes: bus, train, and flight
class Travels{

    public static void SelectMode(){
        string? mode;
        Console.WriteLine("Select a mode: 1. Bus, 2. Train, 3. Flight");
        mode = Console.ReadLine();

        switch (mode){
            case "bus":
                Console.WriteLine("Booking a bus ticket");
                break;
            case "train":
                Console.WriteLine("Booking a train ticket");
                break;
            case "flight":
                Console.WriteLine("Booking a flight ticket");
                break;
            default:
                Console.WriteLine("Invalid selection. Please Choose Bus, Train, or Flight.");
                break;
        } 
    }
}