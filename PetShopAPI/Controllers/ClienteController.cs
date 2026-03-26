using Microsoft.AspNetCore.Mvc;
using PetShopAPI.Data;

namespace PetShopAPI.Controllers
{
    public class ClienteController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public ClienteController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
