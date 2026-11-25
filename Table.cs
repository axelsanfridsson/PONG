public class Table
{
    public int height { get; }
    public int width { get; }

    public Table(int height, int width)
    {
        this.height = height;
        this.width = width;
    }
    
    public void Render()
    {
        for(int x = 0; x < width; x++)
        {
            Console.SetCursorPosition(x,0);
            Console.Write("-");

            Console.SetCursorPosition(x, height - 1);
            Console.Write("-");
        }
    }
}