using System.Security.Cryptography.X509Certificates;

public class MathManager

{
    public static void Main(string[] args)

    {
        MathManager rrCalculator = new MathManager();
        rrCalculator.Add3Numbers();
        rrCalculator.Add5Numbers(24);
        rrCalculator.Add7Numbers(20,40,60,80,100);

    
        int returnedSum = rrCalculator.Add7Numbers(20,40,60,80,100);
        System.Console.Write("The Answer is...");
        System.Console.WriteLine(returnedSum);
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
        public void Add5Numbers(int num4)
        
        {
        int num5 = 35;
        int num6 = 18;
        int num7 = 27;
        int num8 = 42;
        int sumof5numbers = num4+num5+num6+num7+num8;
        System.Console.WriteLine(sumof5numbers);

        }
        public int Add7Numbers(int num9, int num10, int num11, int num12, int num13)

        {
        int num14 = 120;
        int num15 = 140;
        int sumof7Numbers = num9+num10+num11+num12+num13+num14+num15;
        return sumof7Numbers;

        }

}
