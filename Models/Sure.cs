namespace parcial1.Models;

public class Sure
{
 public string Cobertura {get; set; }
 public string Description {get; set; }
  public bool Lojack {get; set; }
  public decimal Tasa {get; set; }
  public Plan Planes {get; set; }
}


public enum Plan
{
    plan23,
    plan24,
    plan22,
    plan122,
    plan32,
    plan132,
    plan33,
    plan133,
    plan34,
    plan134,
    plan37,
    plan137,
    plan39,
    plan139,
}