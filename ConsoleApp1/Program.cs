using System;

namespace ConsoleApp1
{
    public interface IInjector
    {
        void PersonalInfo();
    }

    public class Bahalul : IInjector
    {
        public void PersonalInfo()
        {
            Console.WriteLine("My name is Dewan Bahalul");
        }
    }

    public class Farhana : IInjector
    {
        public void PersonalInfo()
        {
            Console.WriteLine("My name is Farhana Yasmin");
        }

    }

    public class Alvin : IInjector
    {
        public void PersonalInfo()
        {
            Console.WriteLine("My name is Alvin Dawn");
        }

    }

    public class Client
    {
        readonly IInjector injector;
        public Client(IInjector val)
        {
            this.injector = val;
        }
        public void GetValue()
        {
           injector.PersonalInfo();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            
            IInjector bahalul = new Bahalul();
            Client client = new Client(bahalul);
            client.GetValue();
            Console.ReadLine();
        }
    }
}
