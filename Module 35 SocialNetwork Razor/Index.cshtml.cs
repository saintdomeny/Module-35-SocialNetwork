using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Module_35_SocialNetwork_Razor.ViewModels.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Module_35_SocialNetwork_Razor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public LoginViewModel LoginView { get; set; }
        public RegisterViewModel RegisterView { get; set; }

        public void OnGet()
        {
            // Initialize the view models here
            LoginView = new LoginViewModel();
            RegisterView = new RegisterViewModel();
        }
    }
}
