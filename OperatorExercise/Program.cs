namespace OperatorExercise
{
    public class Program
    {
        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static void PrintAreaOfCircle()
        {
            Console.WriteLine("What is the radius of the circle?");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of a circle with a radius of {radius} is {AreaOfCircle(radius)}");
        }
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            
            int sum = a + b;
            int sub = a - b;
            int mult = a * b;
            
            int quotient = a / b;
            int remainder = a % b;
            
            //Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            //PrintAreaOfCircle();

            var i = 3;
            var j = 4;
            var k = ++i * j++;

            Console.WriteLine(k); // what will be this output?
        }
    }
}
