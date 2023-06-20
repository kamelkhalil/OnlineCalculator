using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineCalculator.Models;
using OnlineCalculator.Services;

namespace OnlineCalculator.Pages
{
    public class IndexModel : PageModel
    {
        private readonly CalculatorService _calculatorService;

        [BindProperty]
        public InputModel Input { get; set; }

        public IndexModel(CalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        public void OnGet()
        {
            Input = new InputModel();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("Result", new
            {
                IsAPrimeNumberText = _calculatorService.IsPrime(Input.A) ? "prime" : "not prime",
                IsADivisorOfBText = _calculatorService.IsDivisor(Input.A, Input.B) ? "a divisor" : "not a divisor",
                IsCDivisorOfABText = _calculatorService.IsDivisor(Input.C, Input.A + Input.B) ? "a divisor" : "not a divisor"
            });
        }
    }
}
