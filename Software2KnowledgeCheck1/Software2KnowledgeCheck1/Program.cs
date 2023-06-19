

using Software2KnowledgeCheck1;

public class Program 
{
    public static void Main(string[] args)
    {
        var constructionlogic = new ConstructionLogic();
        var apartment = new Apartment();
        var highrise = new HighRise();
        var building = new Building();

        var buildings = new List<Building>() { highrise, building};

        constructionlogic.CreateUnit(apartment, buildings);


    }

}