namespace GleemSessions.DesignPatternsDemo.CreationalPatterns.FactoryMethod
{
    public class Thobe : IShirt
    {
        public string Name { get; set; }
            = "Blue Looking Saudi Jallabiya";

        public void Describe()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Now this is some fine looking jallabs you can buy cheap.");
            Console.Write($"it's called the ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Name);
            Console.ResetColor();
        }
    }
}
