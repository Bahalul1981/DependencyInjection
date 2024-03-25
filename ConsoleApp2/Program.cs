using System.Threading.Channels;

namespace ConsoleApp2
{


    // Inhector Interface

    public interface IInjector
    {
        string Name { get; }
       
    }

    public class PersonOne : IInjector
    {
        public string Name { get; set; } = "Arvid Dawn Amin";

    }
    public class PersonTwo : IInjector
    {
        public string Name { get; set; } = "Farhana Yasmin";

    }
    public class PersonThree : IInjector
    {
        public string Name { get; set; } = "Alvin Dawn";

    }

    public class ClientClass
    {
        readonly IInjector injector;

        public ClientClass(IInjector injector)
        {
            this.injector = injector;
        }
        public void GetValue () 
        {
            Console.WriteLine(injector.Name);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
          IInjector enj= new PersonThree();

          ClientClass clientClass = new ClientClass(enj);

            clientClass.GetValue();

           Console.ReadLine();
        }
    }
}
