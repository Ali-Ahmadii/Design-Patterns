using System;
namespace Decorator;
class Program
{
    public static void Main(string[] args)
    {
        Pizza peproni = new Peperoni();
        Console.WriteLine(peproni.Name + " " + peproni.Cost());
        Pizza peperoniWithExtraCost = new Peperoni();
        peperoniWithExtraCost = new ExtraSauce(peperoniWithExtraCost);
        peperoniWithExtraCost = new ExtraSauce(peperoniWithExtraCost);
        Console.WriteLine(peperoniWithExtraCost.Name + " " +peperoniWithExtraCost.Cost());
    }
}

