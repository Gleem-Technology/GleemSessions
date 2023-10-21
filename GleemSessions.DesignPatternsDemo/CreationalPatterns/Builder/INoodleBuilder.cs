using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GleemSessions.DesignPatternsDemo.CreationalPatterns.Builder
{
    public interface INoodleBuilder
    {
        void BoilWater();
        void AddSpices();
        void AddBrandRawNoodle();
        void AddEggs();

        void StartAfresh();
    }
}
