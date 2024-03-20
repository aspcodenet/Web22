using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web2.Data;

namespace Web2.Pages
{
    public class CustomersModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public List<Customer> Customers { get; set; }

        public CustomersModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Customers = _context.Customers.Take(100).ToList();
        }
    }
}
