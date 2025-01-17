using Microsoft.EntityFrameworkCore;
using Myexam.Data;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Myexam.Models;

namespace Myexam.Controllers;

public class DashboardController : Controller
{
   
    private readonly ApplicationDbContext _context;
    private IWebHostEnvironment _webHostEnvironment;
    public DashboardController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment) {
        _context = context;
        _webHostEnvironment = webHostEnvironment;
        
    }


    public IActionResult Index()
    {
        return View();
    }

    public IActionResult CreateNewCategories(Categories categories)
    {
        _context.Add(categories);
        _context.SaveChanges();
        return RedirectToAction("Categories");
    }

     public IActionResult Categories(){
        var getdata = _context.categories.ToList();
        return View(getdata);
        

     }

     
    public IActionResult CreateNewCategoriesTransportation(CategoriesTransportation categoriesTransportation){
        _context.Add(categoriesTransportation);
        _context.SaveChanges();
        return  RedirectToAction("CategoriesTransportation");
        

    }
    public IActionResult CategoriesTransportation(){
        var getdata = _context.categoriesTransportation.ToList();
        return View(getdata);
        

    }

    
     














    
    // [Route("Betool")]

    public IActionResult Privacy()
    {
        return View();
    }

    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
