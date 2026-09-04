using System;
namespace Decorator{

public class Peperoni : Pizza
{
    public Peperoni()
    {
        Size = 1;
        Name = "I am a peperoni";
    }
    public override int Size { get; set ; }

    public override double Cost()
    {
        return 5.30;
    }
}
}