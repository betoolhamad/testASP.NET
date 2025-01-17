using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Myexam.Models;
using Myexam.Data;

namespace Myexam.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;

    public HomeController(ILogger<HomeController> logger , ApplicationDbContext context)
    {
        _logger = logger;
        _context=context;
    }

    public IActionResult Index()
    {
        var categories = _context.categories.ToList();
        return View(categories);
    }
    
    // [Route("Betool")]

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Categories()
    {
        var cat = new List<Categories> {

            new Categories {
                Id = 1,
                Name="الملاعب",
                Description= " تحتوي الماعب على مقاعد وشاشات",
                Icon="*",
                Url="Stadiums"
            },

            new Categories {
                Id = 2,
                Name="الفنادق",
                Description= "فنادق من خمسة نجوم",
                Icon="**",
                Url="Hotels"
            },

             new Categories {
                Id = 3,
                Name="النقل",
                Description= "انواع طرق النقل",
                Icon="***",
                Url="Transportation"
            },



        };
        return View(cat);
    }

    public IActionResult Stadiums()
    {
        var stud = new List<Stadiums>  {

            new Stadiums {
                Id=1,
                Name="ملعب الملك فهد الدولي ",
                Capacity=68752,
                City="الرياض",
                Type= "كرة قدم",
                ConstractionDate= new DateTime(1979,6,18),
                Owner="الهيئة العامة للرياضة",
                Length=105,
                width= 68,
                Desc="مدينة الملك فهد الرياضية (الإسم السابق: ستاد الملك فهد الدولي) في مدينة الرياض وسط السعودية، يقع في الجزء الشرقي من المدينة. ويلقب بـ«استاد الخيمة» وبـ«درة الملاعب»، وأنشئ الموقع على مساحة إجمالية تبلغ 500 ألف متر2، المنشأة تمتلكها الحكومة ممثلة بالهيئة العامة للرياضة وكانت انطلاقة المشروع يوم 7 ديسمبر 1982 واستغرق التنفيذ مدة أربع سنين وأربع شهور ووصل عدد العاملين فيه أوقات الذروة 1.800 عامل يعملون كل يوم على مدار ثلاث فترات، وتستوعب مدرجات الاستاد أكثر من 68 ألف متفرج لكل متفرج مقعد خاص فيه.",
                Images="Images/Stadiums.jpg",
                Facility= new List<string> {  "مطاعم" , "شاشة كبيرة ", "مواقف سيارات"}

            },

            new Stadiums{
                Id=2,
                Name="ملعب مدينة الملك عبدالله الدولي ",
                Capacity=48752,
                City="جدة",
                Type= "كرة قدم",
                ConstractionDate= new DateTime(1979,6,18),
                Owner="الهيئة العامة للرياضة",
                Length=105,
                width= 68,
                Desc="مدينة الملك عبد الله الرياضية في مدينة جدة غرب السعودية. تقع المدينة الرياضية شمال مطار الملك عبد العزيز الدولي، تحتوي المدينة على ملعب مدينة الملك عبد الله الرياضية ملعب كرة قدم وصالة مدينة الملك عبد الله الرياضية، وصالة ألعاب رياضية ومسجد مدينة الملك عبد الله الرياضية وثلاثة ملاعب رديفة ومواقف سيارات. يلقب الملعب الرئيسي بـ (الجوهرة المشعة)، بدأ البناء في المشروع سنة 2013 وانتهى البناء بنهاية شهر أبريل سنة 2014.",
                Images="Images/squer.jpg",
                Facility= new List<string> {  "مطاعم" , "شاشة كبيرة ", "مواقف سيارات"}
            },

              new Stadiums{
                Id=3,
                Name="ملعب الأمير عبدالله الفيصل",
                Capacity=48752,
                City="الرياض",
                Type= "كرة قدم",
                ConstractionDate= new DateTime(1979,6,18),
                Owner="الهيئة العامة للرياضة",
                Length=105,
                width= 68,
                Desc="مدينة الأمير عبد الله الفيصل الرياضية تقع في جنوب شرق مدينة جدة، ويتسع ملعب المدينة لـ 27,000 متفرج، تم ترميمه وإعادة افتتاحه في عام 2021.",
                Images="Images/stadiumsfront.jpg",
                Facility= new List<string> {  "مطاعم" , "شاشة كبيرة ", "مواقف سيارات"}
            }


        };
        return View(stud);
    }

     public IActionResult Hotels()
    {
        return View();
    }

     public IActionResult Transportation()
    {
        return View();
    }
    
    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
