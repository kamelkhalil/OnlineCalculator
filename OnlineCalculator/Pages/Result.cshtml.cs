using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OnlineCalculator.Pages
{
    public class ResultModel : PageModel
    {
        public string IsAPrimeNumberText { get; set; }
        public string IsADivisorOfBText { get; set; }
        public string IsCDivisorOfABText { get; set; }

        public void OnGet(string isAPrimeNumberText, string isADivisorOfBText, string isCDivisorOfABText)
        {
            IsAPrimeNumberText = isAPrimeNumberText;
            IsADivisorOfBText = isADivisorOfBText;
            IsCDivisorOfABText = isCDivisorOfABText;
        }
    }
}
