using System.Collections.Generic;
using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
//using PEPESIX.Models;
using pitpm_pr1.Models;
using pitpm_pr1.Controllers;
using Microsoft.Extensions.Configuration;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Numerics;

namespace pitpm_pr1.Controllers
{
    public class Car
    {

        //public string Name;
        //public string Mileage;
        //public string Year;
        //public Car(string Name, string Mileage, string Year)
        //{
        //    this.Name = Name;
        //    this.Mileage = Mileage;
        //    this.Year = Year;
        //}
    }
    public class Cars
    {
        //public static List<Car> All_cars = new List<Car>();
        //public Cars()
        //{

        //}
        //public static void AddCar(string Name, string Mileage, string Year)
        //{
        //    All_cars.Add(new Car(Name, Mileage, Year));

        //}
    }
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _config;

        public HomeController(ILogger<HomeController> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }
        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            }
        }
        private List<User> GetAllUsers()
        {
            using(IDbConnection db = Connection)
            {
                var result = db.Query<User>("Select * from Users").ToList();//получение листа
                return result;
            }
        }
        public class User
        {
            public int user_id { get; set; }
            public string surname { get; set; }
            public string name { get; set; }
            public long phone_numb { get; set; }
            public Nullable<System.DateTime> date_birthday { get; set; }
            public string password { get; set; }
            public bool admin_check { get; set; }

        }

        public IActionResult Index()
        {
            var items = GetAllUsers();
            return View(items);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public int _counter = 0;
        public IActionResult Seans()
        {
            return View();
        }
        public IActionResult Registr()
        {
            return View();
        }
       
        public IActionResult Toyota_Mark_II()
        {
            return View();
        }

        
        [HttpPost]


        //public IActionResult Mazda_RX_7(string Predlozhenie)
        //{

        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Registr(string Nazvanie, string Mileage, string Year, string fn, string fa, string fy) //вот это надо удалить 
        //{
        //    Cars.AddCar(Nazvanie, Mileage, Year);
        //    for (int i = 0; i < Cars.All_cars.Count; i++)
        //    {
        //        if (fn == Cars.All_cars[i].Name)
        //        {
        //            ViewBag.N = Cars.All_cars[i].Name + ", ";
        //            ViewBag.A = Cars.All_cars[i].Mileage + ", ";
        //            ViewBag.Y = Cars.All_cars[i].Year + " ";
        //        }
        //    }
        //    return View();
        //}



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}