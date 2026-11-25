public class Ball : IEntity
// Ansvarar för bollens position och direction, rörelse/hastighet och studs
{
    private int xposition;
    private int yposition;
    private double speed = 1;
    private double xdirection = 1;
    private double ydirection = 0;

    public Ball(Table table)
    {
        xposition = table.width / 2;
        yposition = table.height / 2;
    }

    public void Update()
    {
        xposition += (int)(xdirection * speed);
        yposition += (int)(ydirection * speed);
    }

    public void Render(Table table)
    {
        Console.SetCursorPosition(xposition, yposition);
        Console.Write("O");
        Console.SetCursorPosition(0, table.height);
    }

    public void Bounce()
    {
        
    }
}