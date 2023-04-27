using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public abstract class AbstractAnimal
    {
        public string Name { get; set; }
        public BiomType Biom { get; protected set; }
        public int NeededArea { get; protected set; }
        public bool IsPredator { get; protected set; }

        protected string _sound;
        public AbstractAnimal(string name)
        {
            Name = name;
        }
        public void Add(string Animal)
        {
            Console.WriteLine($"Name:{Name}");
        }
       
    }
} 
