public class Ball : IEntity
// Ansvarar för bollens position och direction, rörelse/hastighet och studs
{
    private int xposition;
    private int yposition;
    private int speed = 1;
    private int xdirection = 1;
    private int ydirection = 0;
    private Paddle paddle1;
    private Paddle paddle2;

    public Ball(Table table, Paddle paddle1, Paddle paddle2)
    {
        xposition = table.width / 2;
        yposition = table.height / 2;
        this.paddle1 = paddle1;
        this.paddle2 = paddle2;
    }

    public void Update()
    {
        xposition += (xdirection * speed);
        yposition += (ydirection * speed);
    }

    public void Render(Table table)
    {
        Console.SetCursorPosition(xposition, yposition);
        Console.Write("O");
        Console.SetCursorPosition(0, table.height);
    }

    public void Bounce(Table table, Paddle paddle1, Paddle paddle2)
    {
         // Studs mot toppen och botten
        if (yposition <= 0 || yposition >= table.height - 1)
        {
            ydirection *= -1;
        }

        // Studs mot första paddeln
        if (xposition == paddle1.xposition &&
            yposition >= paddle1.yposition &&
            yposition < paddle1.yposition + paddle1.paddleSize.Length)
        {
            xdirection *= -1;
        }

        // Studs mot andra paddeln
        if (xposition == paddle2.xposition &&
            yposition >= paddle2.yposition &&
            yposition < paddle2.yposition + paddle2.paddleSize.Length)
        {
            xdirection *= -1;
        }
    }
}