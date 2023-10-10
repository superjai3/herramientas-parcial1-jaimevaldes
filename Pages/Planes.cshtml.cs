using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace parcial1.Pages;

public class PlanesModel : PageModel
{
    private readonly ILogger<PlanesModel> _logger;

    public PlanesModel(ILogger<PlanesModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

