using System.ComponentModel;
using Zoo;

//List<AbstractAnimal> list = new List<AbstractAnimal>();
//AbstractAnimal.Add(new SlonAnimal("Petya"));
//AbstractAnimal.Add(new TigerAnimal("Petya"));
//AbstractAnimal.Add(new PinguinAnimal("Petya"));

//foreach (AbstractAnimal animal in list)
//{
//   AbstractAnimal.Add();
//}
Valyer valyer = new Valyer (2, BiomType.Tundra,30);

valyer.AddAnimal(new TigerAnimal("Matilda"));
valyer.AddAnimal(new SlonAnimal("Petya"));
valyer.AddAnimal(new PinguinAnimal("Simba"));


