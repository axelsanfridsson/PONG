public class Ball : IEntity
// Ansvarar för bollens position och direction, rörelse/hastighet och studs
{
    private int xposition;
    private int yposition;
    private int speed = 1;
    private int xdirection = 1;
    private int ydirection = 1;
    private Paddle paddle1;
    private Paddle paddle2;
    private Table table;

    public Ball(Table table, Paddle paddle1, Paddle paddle2)
    {
        xposition = table.width / 2;
        yposition = table.height / 2;
        this.paddle1 = paddle1;
        this.paddle2 = paddle2;
        this.table = table;
    }

    public void Update()
    {
        xposition += (xdirection * speed);
        yposition += (ydirection * speed);

        Bounce(table);
    }

    public void Render(Table table)
    {
        Console.SetCursorPosition(xposition, yposition);
        Console.Write("O");
        Console.SetCursorPosition(0, table.height);
    }

    public void Bounce(Table table)
    {
        // Top and bottom walls
        if (yposition <= 0 || yposition >= table.height - 1)
        {
            ydirection *= -1;
        }

        // Paddle collisions
        if (paddle1.CheckCollision(xposition, yposition) ||
            paddle2.CheckCollision(xposition, yposition))
        {
            xdirection *= -1;
        }
    }
}