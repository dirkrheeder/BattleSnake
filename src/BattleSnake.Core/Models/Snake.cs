namespace BattleSnake.Core.Models;

public class Snake
{
  public string Id { get; set; }
  public string Name { get; set; }
  public int Health { get; set; }
  public IEnumerable<Point> Body { get; set; }
  public string Latency { get; set; }
  public IEnumerable<Point> Head { get; set; }
  public int Length { get; set; }
  public string Shout { get; set; }
  public string Squad { get; set; }
  public Customizations Customizations { get; set; }
}
