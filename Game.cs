public class Game
// Kontrollerar game-loopen, updaterar positioner, tick-system? och hanterar game states
{
    private IEntity[] entities = [];
    public Game(IEntity[] entities)
    {
        while(true)
        {
            foreach(IEntity obj in entities)
            {
                obj.Update();
            }
        }
    }
}