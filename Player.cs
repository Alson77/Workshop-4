namespace Week4_Assignment;

public class Player
{
    public string playerName;
    public int level;
    public int health;

    //  Creating Default constructor
    public Player()
    {
        Console.WriteLine("Default constructor has been called");
    }

    // Creating Parameterized constructor
    public Player(string name, int level, int health)
    {
        this.playerName = name;
        this.level = level;
        this.health = health;
    }
}