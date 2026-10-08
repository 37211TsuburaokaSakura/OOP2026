using Microsoft.AspNetCore.Mvc;         // MVCの機能を使用 
using Microsoft.EntityFrameworkCore;    // ToListAsyncを使用 
using MvcBasicSample.Data;              // AppDbContextを使用

namespace MvcBasicSample.Controllers;

public class ProductsController :Controller{
    // DBへ問い合わせるためのフィールド
    private readonly AppDbContext _db;

    public ProductsController(AppDbContext db) {
        _db = db;
    }

    // /Products/Indexで商品一覧を取得する(非同期メソッド)
    public async Task<IActionResult> Index() {
        //Idの昇順で取得し　結果をLIst<Product>にする
        var products = await　_db.Products.OrderBy(products =>products.Price).ToListAsync();

        return View(products);
    }



    }

