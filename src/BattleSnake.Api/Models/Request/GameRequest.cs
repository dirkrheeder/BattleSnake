namespace BattleSnake.Api.Models.Request;

public class GameRequest
{
    public Game Game { get; set; }
    public int Turn { get; set; }
    public Board Board { get; set; }
    public Snake You { get; set; }
}
