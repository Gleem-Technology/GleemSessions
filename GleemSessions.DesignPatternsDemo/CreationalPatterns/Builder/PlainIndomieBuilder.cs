using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GleemSessions.DesignPatternsDemo.CreationalPatterns.Builder
{
    public class PlainIndomieBuilder : INoodleBuilder
    {
        Indomie indomie = new Indomie();

        public void AddBrandRawNoodle()
        {
            indomie.Brand = "Indomie";
        }

        public void AddEggs()
        {
            indomie.EggCount = 0;
        }

        public void AddSpices()
        {
            indomie.Spices = string.Empty;
        }

        public void BoilWater()
        {
            indomie.WaterContent = "Everything soaked into the noodle";
        }

        public void StartAfresh()
        {
            indomie = new Indomie();
        }

        public Indomie Prepare()
        {
            return indomie;
        }
    }
}
