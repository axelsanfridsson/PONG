public class Table
{
    public int height;
    public int width;

    public Table(int height, int width)
    {
        this.height = height;
        this.width = width;
    }
    
    public void Render()
    {
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                Console.SetCursorPosition(x, y);

                if (y == 0 || y == height - 1)
                    Console.Write("-");
                else
                  Console.Write(" ");
            }
        }
    }
}