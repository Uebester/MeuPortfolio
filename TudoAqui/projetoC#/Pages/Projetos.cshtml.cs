using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MeuPortfolio.Pages;

public class ProjetosModel : PageModel
{
    private readonly ILogger<ProjetosModel> _logger;

    public ProjetosModel(ILogger<ProjetosModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

