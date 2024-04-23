using Microsoft.AspNetCore.Mvc;

namespace Math.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("Math/ShowNumber/{id}")]
        public IActionResult ShowNumber(int id)
        {
            ViewBag.Id = id;
            return View();
        }
        [Route("Math/ShowSum/{num1}/{num2}")]
        public IActionResult ShowSum(int num1, int num2)
        {
            int result;
            result = num1+num2;
            ViewBag.Num = result;
            return View();
        }
        public IActionResult Equation()
        {
            return View();
        }
    }
}
