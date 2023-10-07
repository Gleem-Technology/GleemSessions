namespace GleemSessions.DesignPatternsDemo.CreationalPatterns.FactoryMethod
{
    public class ApoBridgeConductorShirt : IShirt
    {
        public string Name { get; set; }
            = "Under the Bridge Sweatshirt";

        public void Describe()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Approved by the APO BRIDGE CONDUCTORS ASSOCIATION OF ABUJA (ABCAA).");
            Console.WriteLine("We present to you..");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Name);
            Console.ResetColor();
        }
    }
}
