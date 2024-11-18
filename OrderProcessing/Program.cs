using System.Diagnostics;

public class Program{
    public static void Main(string[] args){
        // program that processes multiple orders by their status: pending, shipped, delivered, or cancelled
        string[] orderStatuses = {"Pending", "Shipped", "Delivered", "Cancelled"};

        for(int i = 0; i < orderStatuses.Length; i++){
            switch (orderStatuses[i]){
                case "Pending":
                    Console.WriteLine("order is pending");
                    break;
                case "Shipped":
                    Console.WriteLine("order hash been shipped");
                    break;
                case "Delivered":
                    Console.WriteLine("Order hs been delivered");
                    break;
                case "Cancelled":
                    Console.WriteLine("Order has been cancelled");
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;        
            }
        }        
    }
}