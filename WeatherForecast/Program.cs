public class Program{
    public static void Main(string[] args){
        // program that evaluates weather conditions using switch statements and returns what clothes to wear
        string[] weatherForecasts = {"Sunny and warm", "rainy with thunderstorms", "cloudy and cold"};

        for (int i = 0; i < weatherForecasts.Length; i++){
            switch (weatherForecasts[i]){
            case "Sunny and warm":
                Console.WriteLine("The weather is "+ weatherForecasts[0]+ " please dress warm");
                break;
            case "rainy with thunderstorms":
                Console.WriteLine("The weather is "+ weatherForecasts[1]+ " carry an umbrella");
                break;
            case "cloudy and cold":
                Console.WriteLine("The weather is "+ weatherForecasts[2]+ " please carry a sweater");
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
        }
    }
}