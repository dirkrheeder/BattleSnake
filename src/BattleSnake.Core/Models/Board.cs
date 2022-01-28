namespace BattleSnake.Core.Models;

public class Board
{
  public int Height { get; set; }
  public int Width { get; set; }
  public IEnumerable<Point> Food { get; set; }
  public IEnumerable<Snake> Snakes { get; set; }
  public IEnumerable<Point> Hazards { get; set; }
}
