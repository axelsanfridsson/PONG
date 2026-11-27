public class Paddle : IEntity
// Ansvarar för padelns position och spelarrörelse
{
    private int xposition;
    private int yposition;
    private int[] paddleSize;
    private IController controller;

    public Paddle(Table table, int xposition, int[] paddleSize)
    {
        this.xposition = xposition;
        this.paddleSize = paddleSize;
        this.yposition = table.width / 2;
        paddleSize[0] = yposition;

        for(int i = 1; i < paddleSize.Length; i++)
        {
            paddleSize[i]++;
        }
    }

    public void Update()
    {
        int direction = controller.GetDirection();
        if (direction == -1)
        {
            yposition--;

            for (int i = 0; i < paddleSize.Length; i++)
            {
                paddleSize[i]--;
            }
        }
        else if (direction == 1)
        {
            yposition++;

            for (int i = 0; i < paddleSize.Length; i++)
            {
                paddleSize[i]++;
            }
        }
    }

    public bool CheckCollision(int ballX, int ballY)
{
    if (ballX == xposition &&
        ballY >= yposition &&
        ballY < yposition + paddleSize.Length)
    {
        return true;
    }

    return false;
}

    public void Render(Table table)
    {
        foreach(int position in paddleSize)
        {
            Console.SetCursorPosition(xposition, position);
            Console.Write("|");
        }
    }
}