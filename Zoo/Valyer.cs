using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Valyer
    {
        public List<AbstractAnimal> animals { get; protected set; }
        public int NumberOfAnimal{ get; protected set; }
        public BiomType Biom { get; protected set; }
        public int Square{ get; protected set; }

        public Valyer ( int numberOfAnimal, BiomType biom, int square)
        {
            NumberOfAnimal = numberOfAnimal;
            Biom = biom;
            Square = square;
            animals = new List<AbstractAnimal> ();
        }

        public void AddAnimal(AbstractAnimal animal)
        {
            if (Biom == animal.Biom && GetFreeSpace()>=animal.NeededArea && IsPredatorThere()==animal.IsPredator ||  animals.Count==0)
            {
                animals.Add(animal);
            }
            else
            {
                throw new Exception();
            }
        }
        private int GetFreeSpace()
        {
          int freeSpace = Square;
            foreach (AbstractAnimal animal in animals)
            {
                freeSpace-=animal.NeededArea;
            }
            return freeSpace;
        }
        public bool IsPredatorThere()
        {
            bool result = false;
            foreach(AbstractAnimal animal in animals)
            {
                if(animal.IsPredator)
                {
                    result = true;
                }
            }
            return result;
        }
        public void RemoveAnimal( int number )
        { 
            {
                animals.RemoveAt(number);
            }
      
        }

    }
}
