namespace Zoo
{
    public class PinguinAnimal : AbstractAnimal
    {
        public PinguinAnimal(string name):base(name)
        {
            Biom = BiomType.Tundra;
            NeededArea = 30;
            IsPredator = true;
            _sound = "XruXru";
        }
    }
}
