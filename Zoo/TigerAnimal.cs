using System.Security.Cryptography.X509Certificates;

namespace Zoo
{
    public class TigerAnimal : AbstractAnimal
    {
        public TigerAnimal(string name ):base(name)
        {
            Biom = BiomType.Desert;
            NeededArea= 50;
            IsPredator=false;
            _sound ="Rrrr";
       }
    }
}
