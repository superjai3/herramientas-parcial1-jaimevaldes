using parcial1.Models;
using parcial1.Pages;

namespace parcial1.Services;

public static class PlanService
{
    public static List<Sure> PlanList { get; set; } = new List<Sure>();

    public static List<Sure> GetAll()
    {
        if (PlanList.Count() == 0)
        {
            
            var plan1 = new Sure();
            plan1.Cobertura = "Responsabilidad Civil";
            plan1.Description = "Contrato de Responsabilidad Civil por daños y perjuicios.";
            plan1.Lojack = false;
            plan1.Planes = Plan.plan23;
            plan1.Tasa = 1;
            PlanList.Add(plan1);


            var plan2 = new Sure();
            plan2.Cobertura = "Todo Total";
            plan2.Description = "RC + Robo Total + Incendio Total";
            plan2.Lojack = false;
            plan2.Planes = Plan.plan24;
            plan2.Tasa = 2;
            PlanList.Add(plan2);


            var plan3 = new Sure();
            plan3.Cobertura = "Tercero Completo";
            plan3.Description = "RC + Robo Total/Parcial + Incendio Total/Parcial";
            plan3.Lojack = false;
            plan3.Planes = Plan.plan122;
            plan3.Tasa = 3;
            PlanList.Add(plan3);
        
        }
            return PlanList;
    }   

    public static void Delete(string Cobertura)
    {
        var item = PlanList.FirstOrDefault(x=> x.Cobertura.ToLower() == Cobertura);
        if (item != null)
        {
            PlanList.Remove(item);
        }
    }

    public static void Create(Sure newSure)
    {
        PlanList.Add(newSure);
    }

    public static void Update()
    {

    }

    internal static void Delete()
    {
        throw new NotImplementedException();
    }
}