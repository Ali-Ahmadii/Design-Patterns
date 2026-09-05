namespace Factory
{
    public class Program
    {
        static void Main()
        {
            var creatorA = new ConcrateCreatorA();
            Console.WriteLine(creatorA.GetID());
        }
    }
}