public class InputController : IController
// Ansvarar för inputvalidering
{
    private ConsoleKey upKey;
    private ConsoleKey downKey;

    public InputController(ConsoleKey upKey, ConsoleKey downKey)
    {
        this.upKey = upKey;
        this.downKey = downKey;
    }

    public int GetDirection()
    {
        if (!Console.KeyAvailable)
            return 0;

        ConsoleKey key = Console.ReadKey(true).Key;

        if (key == upKey)
            return -1;

        if (key == downKey)
            return 1;

        return 0;
    }
}
