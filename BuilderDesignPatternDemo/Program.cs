using BuilderDesignPatternDemo.Models;

namespace BuilderDesignPatternDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mobile mobile;
            MobileDirector director;

            Console.WriteLine("~~~~~ POC on Builder Design Pattern ~~~~~");

            //Building a apple mobile
            AppleBuilder apple = new AppleBuilder();
            director = new MobileDirector(apple);
            mobile = apple.GetInfo();
            Console.WriteLine(mobile.DisplayInfo());

            //Building nokia mobile
            NokiaBuilder nokia = new NokiaBuilder();
            director = new MobileDirector(nokia);
            mobile = nokia.GetInfo();
            Console.WriteLine(mobile.DisplayInfo());

        }
    }
}
