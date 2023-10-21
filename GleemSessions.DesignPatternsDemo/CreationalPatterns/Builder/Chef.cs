using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GleemSessions.DesignPatternsDemo.CreationalPatterns.Builder
{
    public class Chef
    {
        INoodleBuilder _noodleBuilder;

        public Chef(INoodleBuilder noodleBuilder)
        {
            _noodleBuilder = noodleBuilder;
        }

        public void BuildNoodle()
        {
            _noodleBuilder.BoilWater();
            _noodleBuilder.AddSpices();
            _noodleBuilder.AddBrandRawNoodle();
            _noodleBuilder.AddEggs();
        }
    }
}
