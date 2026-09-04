using System;
namespace Decorator{

public class ExtraSauce : PizzaDecorator
{
    private readonly Pizza _pizza;
    public ExtraSauce(Pizza pizza)
    {
        _pizza = pizza;
    }
    public override int Size { get ; set; }

    public override double Cost()
    {
       return  _pizza.Cost() + 0.5 ;
    }
    public override string Name { get => _pizza.Name + " with ExtraSauce"; }
}
}