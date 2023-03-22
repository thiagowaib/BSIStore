using Microsoft.AspNetCore.Mvc;

namespace BSIStore.Controllers;

public class StoreController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public void PostUserData(IFormCollection collection)
    {
        ViewData["name"] = collection["name"];
        ViewData["age"] = collection["age"];
    }

    [HttpGet]
    public JsonResult GetUserData()
    {
        var result = new {
            name = ViewData["name"],
            age = ViewData["age"]
        };

        return Json(result);
    }
}
