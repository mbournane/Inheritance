namespace Inheritance;

class Program
{
    static void Main(string[] args)
    {
        Animal[] animals = new Animal[4];
        Bipeds clever = new Bipeds("Humain", true);
        Bipeds likeHuman = new Bipeds("Singe", false);
        Quadrupeds theBigger = new Quadrupeds("elaphent", false);
        Quadrupeds  theKing = new Quadrupeds("Lion", false);
        animals[0] = clever;
        animals[1] = likeHuman;
        animals[2] = theBigger;
        animals[3] = theKing;

        foreach (Animal animal in animals)
        {
            Console.WriteLine($"The {animal.GetName()}");
            animal.Move();
            animal.Eat();
        }
    }
}
