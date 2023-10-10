using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using parcial1.Models;
using parcial1.Services;

namespace parcial1.Pages
{
    public class SureListModel : PageModel
    {
        public List<Sure> Planes {get; set;} = new List<Sure>();

        [BindProperty]
        public Sure NewSure {get; set;}
        
        public void OnGet()
        {
            //Planes = new List<Sure>();

            /*var plan1 = new Sure();
            plan1.Cobertura = "Responsabilidad Civil";
            plan1.Description = "Contrato de Responsabilidad Civil por daños y perjuicios.";
            plan1.Lojack = false;
            plan1.Planes = Plan.plan23;
            plan1.Tasa = 1;
            Planes.Add(plan1);


            var plan2 = new Sure();
            plan2.Cobertura = "Todo Total";
            plan2.Description = "RC + Robo Total + Incendio Total";
            plan2.Lojack = false;
            plan2.Planes = Plan.plan24;
            plan2.Tasa = 2;
            Planes.Add(plan2);


            var plan3 = new Sure();
            plan3.Cobertura = "Tercero Completo";
            plan3.Description = "RC + Robo Total/Parcial + Incendio Total/Parcial";
            plan3.Lojack = false;
            plan3.Planes = Plan.plan122;
            plan3.Tasa = 3;
            Planes.Add(plan3);*/

            Planes = PlanService.GetAll();
        }
    

        public IActionResult OnPost()
        {
            var newObject = NewSure;
            PlanService.Create(newObject);

            /*Planes.Add(newObject);*/

            //return RedirectToAction("Get");
            return RedirectToPage("SureList");
        }    

        public IActionResult OnPostDelete(string cobertura)
        {
            PlanService.Delete(cobertura);
            return RedirectToAction("Get");
        }    



    }
}
