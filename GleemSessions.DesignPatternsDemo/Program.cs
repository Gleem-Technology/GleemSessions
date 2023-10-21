using GleemSessions.DesignPatternsDemo.CreationalPatterns.Builder;

namespace GleemSessions.DesignPatternsDemo
{
    internal class Program
    {
        static void Main()
        {
            //IGarmentFactory factory = new ArabianGarmentFactory();
            //var garment = factory.CreateGarment();
            //garment.Describe();

            //IClothFactory factory = new NigerianClothFactory();
            //IShirt shirt = factory.CreateShirt();
            //ITrouser trouser = factory.CreateTrouser();
            //shirt.Describe();
            //trouser.Describe();

            var builder = new GarlicRamenBuilder();
            var chef = new Chef(builder);
            chef.BuildNoodle();
            Ramen ramen = builder.GetRamen();
            Console.WriteLine(ramen);
        }
    }
}