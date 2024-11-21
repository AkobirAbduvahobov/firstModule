namespace _8dars;

public class Planet
{
    public string Name { get; set; }

    public string Description { get; set; }

    public double Diameter { get; set; }

    public bool LifePotentional { get; set; }

    public bool ExistsOxygen { get; set; }

    public int Gravity { get; set; }




    public Planet()
    {
        
    }

    public Planet(string name, string description, double diameter, 
        bool lifePotentional, bool existsOxygen, int gravity)
    {
        Name = name;
        Description = description;
        Diameter = diameter;
        LifePotentional = lifePotentional;
        ExistsOxygen = existsOxygen;
        Gravity = gravity;
    }



}
