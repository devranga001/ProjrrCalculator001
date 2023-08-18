public class MathManager

{
    public static void Main(string[] args)

    {
        MathManager rrCalculator = new MathManager();
        rrCalculator.Add3Numbers();
    }
        //Adds 3 Numbers
        public void Add3Numbers()
        { 
        // Give me memory num1 with value 75 and I am going to call it    
        int num1 = 75;
        int num2 = 25;
        int num3 = 50;
        int sum = num1+num2+num3;
        System.Console.WriteLine(sum);

        }

}