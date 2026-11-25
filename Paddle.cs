public class Paddle : IEntity
// Ansvarar för padelns position och spelarrörelse
{
    private int xposition;
    private int yposition;
    private int[] paddleSize;

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
        
    }

    public void Render(Table table)
    {
        foreach(int position in paddleSize)
        {
            Console.SetCursorPosition(xposition, yposition);
            Console.Write("|");
            yposition++;
        }
    }
}