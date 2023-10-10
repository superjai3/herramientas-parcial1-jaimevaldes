using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace parcial1.Pages;


public class SolicitudModel : PageModel
{
    private readonly ILogger<SolicitudModel> _logger;

    public SolicitudModel(ILogger<SolicitudModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}
