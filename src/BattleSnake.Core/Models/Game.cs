namespace BattleSnake.Core.Models;
public class Game
{
  public string Id { get; set; }
  public RuleSet RuleSet { get; set; }
  public int TimeOut { get; set; }
  public string Source { get; set; }
}
