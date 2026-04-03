using Pda;
namespace Demo05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Phone p1=new Phone();
            //p1.PhoneNumber = "12345678";
            //Contract c1=new Contract();
            //c1.Address = "129 Luoroad, Wuhan, Hubei, P.R.China";

            Contract c1 = new Contract();
            c1.FirstName = "Y.B.";
            c1.FamilyName = "Li";
            c1.Address = "129 Luoyu Road, Wuhan";


            Console.WriteLine(c1.FirstName+" "+c1.FamilyName+" "+c1.Address);
            Console.ReadKey();
        }
    }
}
