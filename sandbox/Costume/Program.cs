using System.Linq.Expressions;

namespace Costume;

class Program
{
    static void Main(string[] args)
    {

        List<Costume> myCostume = new List<Costume>();
        Costume detective = new Costume();
        detective._headwear = "fedora";
        detective._upperGarments = "trenchcoat";
        detective._lowerGarment = "slacks";
        detective._footware = "dress shoes";
        detective._accessories = "magnifing glass";
        myCostume.Add(detective);

        Costume nurse = new Costume();
        nurse._headwear = "hairnet";
        nurse._upperGarments = "scrubs";
        nurse._lowerGarment = "scrubs";
        nurse._footware = "orthopedic shoes";
        nurse._accessories = "surgical mask";
        myCostume.Add(nurse);

        foreach (Costume c in myCostume)
        {
            c.Output();
        }
    }
}
