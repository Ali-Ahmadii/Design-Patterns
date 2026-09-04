using System;
namespace Decorator{
public class MixPizza : Pizza
{
    public MixPizza()
    {
        this.Size = 1;
        Name = "I am a MixPizza";
    }

    public override int Size { get ; set ; }
    public override double Cost()
    {
        return 5.00;
    }
}
}