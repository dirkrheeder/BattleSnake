namespace BattleSnake.Core.Models;

public class RuleSetSettings
{
  public int FoodSpawnChance { get; set; }
  public int MinimumFood { get; set; }
  public int HazardDamagePerTurn { get; set; }
  public string Map { get; set; }
  public Royale Royale { get; set; }
  public Squad Squad { get; set; }
}

public class Royale
{
  public int ShrinkEveryNTurns { get; set; }
}

public class Squad
{
  public bool AllowBodyCollisions { get; set; }
  public bool SharedElimination { get; set; }
  public bool SharedHealth { get; set; }
  public bool SharedLength { get; set; }
}
