using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetCoreWebAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace DotnetCoreWebAPI.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        private readonly IUserRepo _repository;

        public HomeController(IUserRepo repository)
        {
            _repository = repository;
        }

        //GET home/users
        public IActionResult Index()
        {
            var userItems = _repository.GetAllUsers();

            return View(userItems);
        }

        //GET home/users
        [Route("new")]
        public IActionResult Create()
        {
            return View();
        }
    }
}
