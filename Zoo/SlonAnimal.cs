using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class SlonAnimal:AbstractAnimal
    {
        public SlonAnimal(string name):base(name)
        {
            Biom = BiomType.Tropik;
            NeededArea = 80;
            IsPredator = false;
            _sound = "AufAuf";
        }
    }
}
