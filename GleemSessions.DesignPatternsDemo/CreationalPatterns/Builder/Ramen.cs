using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GleemSessions.DesignPatternsDemo.CreationalPatterns.Builder
{
    public class Ramen
    {
        public int EggCount { get; set; }
        public string Spices { get; set; }
        public string WaterContent { get; set; }
        public int Temperature { get; set; }
        public string Brand { get; set; }

        public override string ToString()
        {
            return $"Spices: {Spices}" +
                $"\nWater Content: {WaterContent}" +
                $"\nBrand: {Brand}" +
                $"\nNo. of Eggs: {EggCount}" +
                $"\nTemp: {Temperature}";
        }
    }
}
