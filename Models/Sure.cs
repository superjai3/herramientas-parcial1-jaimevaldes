namespace parcial1.Models;

public  class Sure
{
 public string Name {get; set; }
 public Plan Plan {get; set; }
 public string Description {get; set; }
 public bool Lojack {get; set; }
  public decimal Price {get; set; }
}

public enum Plan
{
    plan111,
    plan222,
    plan333,
    plan444,
    plan11,
    plan22,
    plan33,
    plan44,
}