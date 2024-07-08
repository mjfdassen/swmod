class RobotBody
{
    string robotType;
    /*
    * To keep a count of number of robots.
    * This operation is optional for you.
    */
    static int count = 0;
    public RobotBody(string robotType)
    {
        this.robotType = robotType;
    }
    public void MakeRobotBody()
    {
        Console.WriteLine($"Constructing one {robotType} robot.");
        Console.WriteLine("Robot creation finished.");
        Console.WriteLine($"Total number of robots created at this moment = {++count}");
    }
    public void DestroyRobotBody()
    {
        if (count > 0)
        {
            --count;
            Console.WriteLine("Robot's destruction process is over.");
        }
        else
        {
            Console.WriteLine("All robots are destroyed.");
            Console.WriteLine("Color removal operation will not continue.");
        }
    }
}

public class RobotColor
{
    string color;
    public RobotColor(string color)
    {
        this.color = color;
    }
    public void SetColor()
    {
        if (color == "steel")
        {
            Console.WriteLine($"The default color {color} is set for the robot.");
        }
        else
        {
            Console.WriteLine($"Painting the robot with your favourite {color} color.");
        }
        Console.WriteLine();
    }
    public void RemoveColor()
    {
        Console.WriteLine("Attempting to remove the colors from the robot.");
    }
}

class RobotFacade
    //opdracht bouw deze facade om naar facade waarin de robot automatisch geconstrueerd wordt.
{
    RobotBody robotBody;
    RobotColor robotColor;
    public RobotFacade(string robotType, string color = "steel")
    {
        robotBody = new RobotBody(robotType);
        robotColor = new RobotColor(color);
        ConstructRobot();
    }
    private void ConstructRobot()
    {
        Console.WriteLine("Robot creation through facade starts...");
        robotBody.MakeRobotBody();
        robotColor.SetColor();
    }
    public void DestroyRobot()
    {
        Console.WriteLine("Making an attempt to destroy one robot using the facade now.");
        robotColor.RemoveColor();
        robotBody.DestroyRobotBody();
    }
}

public class TestRun
{
    static void Main(string[] args)
    {
        //without facade
        RobotBody robotBody = new RobotBody("Milano");
        robotBody.MakeRobotBody();
        RobotColor robotColor = new RobotColor("green");
        robotColor.SetColor();
        //with facade: make a green Milano
        RobotFacade facade1 = new RobotFacade("Milano", "green");
        //facade1.ConstructRobot();
        //with facade: make a steel-colored Robonaut
        RobotFacade facade2 = new RobotFacade("Robonaut");
        //facade2.ConstructRobot();
        //with facade: make a steel-colored Johnny 5
        RobotFacade facade3 = new RobotFacade("Johnny 5");
        facade3.DestroyRobot();
        //facade3.ConstructRobot();
        //Console.ReadKey();
    }
}