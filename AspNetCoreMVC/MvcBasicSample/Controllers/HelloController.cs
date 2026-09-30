using Microsoft.AspNetCore.Mvc;
using MvcBasicSample.Models;

namespace MvcBasicSample.Controllers;
//URLのHELLOに対応する要求を受け取るController
public class HelloController : Controller {

    // .. /Hello/Indexで呼び出されるaction
    public IActionResult Index() {
        //商品1件のオブジェクトを作る
        var products = new List<Product> {
            new Product{
             Name = "ハンバーガー",
             Price = 500

            },
            new Product{
             Name= "紅茶",
             Price = 450
            }
        };

        return View(products);
    }
}

