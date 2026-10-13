namespace Costume;

class Costume()
{
    // attribites
    public string _headwear;
    public string _upperGarments;
    public string _lowerGarment;
    public string _footware;
    public string _accessories;

    // behaviour
    public void Output()
    {
        Console.WriteLine("Costume pieces: ");
        Console.WriteLine($"head: {_headwear}");
        Console.WriteLine($"torso: {_lowerGarment}");
        Console.WriteLine($"legs: {_upperGarments}");
        Console.WriteLine($"feet: {_footware}");
        Console.WriteLine($"accessories: {_accessories}");
    }
}