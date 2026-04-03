namespace Demo03_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = new Complex(3, 4);
            var y = new Complex(7, 8);
            Console.WriteLine("x={0};y={1}",x.ToString() , y.ToString());
            var z = x + y;
            var a = x - y;
            Console.WriteLine("z={0};a={1}",z.ToString() , a.ToString());

            Console.ReadKey();
        }
    }
}
