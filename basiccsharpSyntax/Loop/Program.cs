class Loop {

    public static void changeVal(){
        for (int i = 0; i <= 10; i++){
            Console.WriteLine(i);
        }
    }

    public static void Main(String[] args){
        int value = 6;
        
        changeVal();

        Console.WriteLine(value);
    }
}