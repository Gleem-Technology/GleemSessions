using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GleemSessions.DesignPatternsDemo.CreationalPatterns.Builder
{
    public class GarlicRamenBuilder : INoodleBuilder
    {
        Ramen ramen = new Ramen();

        public void AddBrandRawNoodle()
        {
            ramen.Brand = "Ichiraku";
        }

        public void AddEggs()
        {
            ramen.EggCount = 0;
        }

        public void AddSpices()
        {
            ramen.Spices = "sesame seeds, chilli flakes, garlic, scallions, and stir-fry sauce";
        }

        public void BoilWater()
        {
            ramen.WaterContent = "100ml after boiling";
            ramen.Temperature = 58;
        }

        public void StartAfresh()
        {
            ramen = new Ramen();
        }

        public Ramen GetRamen()
        {
            return ramen;
        }
    }
}
