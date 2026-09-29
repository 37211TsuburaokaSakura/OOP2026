using Microsoft.AspNetCore.Mvc;

namespace MvcBasicSample.Controllers;
//URLのHELLOに対応する要求を受け取るController
public class HelloController : Controller {

    // .. /Hello/Indexで呼び出されるaction
    public IActionResult Index() {
        //viewを使用せず文字列をHTTPの応答として返す
        //return Content("初めてのASP.NET Core");
        return View();
    }
}

