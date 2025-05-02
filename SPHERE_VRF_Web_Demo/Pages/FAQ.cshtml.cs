using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SPHERE_VRF_Web_Client_Test.Pages;

public class FAQModel : PageModel
{
    private readonly ILogger<FAQModel> _logger;

    public FAQModel(ILogger<FAQModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

