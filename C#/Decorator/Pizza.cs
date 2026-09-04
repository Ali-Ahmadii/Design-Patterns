using System;
namespace Decorator;
public abstract class Pizza
{
    public abstract double Cost();
    public abstract int Size { get; set; }
    public virtual string Name { get; set; } = "I am a pizza";
}