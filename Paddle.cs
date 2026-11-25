public class Paddle : IEntity
// Ansvarar för padelns position och spelarrörelse
{
    private int xposition;
    private int[] yposition;

    public Paddle(int[] yposition)
    {
        this.yposition = yposition;
    }

    public void Update()
    {
        
    }
}