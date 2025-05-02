using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SPHERE_VRF_Web_Client_Test.Pages;

public class RequestModel : PageModel
{
    private readonly ILogger<RequestModel> _logger;

    public RequestModel(ILogger<RequestModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

    public async Task<IActionResult> OnPostAsync()
    {
        // Simulate a delay for the request
        var result = Request.Form["rangedRandomNumber"];
        Console.WriteLine($"Random Number is: {result}");
        TempData["Result"] = result;

        return RedirectToPage();
    }
}
