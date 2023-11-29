using Microsoft.AspNetCore.Mvc;
using Modul2Finish.Models;

namespace Modul2Finish.Controllers
{
    public class HomeController : Controller
    {
        public IDataRepository _repository;

        public HomeController(IDataRepository  repository){
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View(_repository.GetAuthors());
        }
    }
}
