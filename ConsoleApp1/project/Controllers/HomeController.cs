using System.Diagnostics;
using ConsoleApp1.project.Models;
using Microsoft.AspNetCore.Mvc;
using project.Models;

namespace project.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Example()
    {
        ViewBag.ex1 = "przykład1";
        ViewData["ex2"] = "przykład2";
        TempData["ex3"] = "przykład3";
        return View();
    }
    public IActionResult Cos()
    {
        var fruits = new List<string>() {"Jabłko","Gruszka","Banan"};

        return View(fruits);
    }
    public IActionResult StudentList()
    {
        var students = new List<Student>() {};
        Student student1 = new Student();
        student1.Name = "Michał";
        student1.Surname = "Kowalski";
        student1.Age = 20;
        student1.StudentId = 1;
        Student student2 = new Student();
        student2.Name = "Krzysztof";
        student2.Surname = "Nowak";
        student2.Age = 22;
        student2.StudentId = 2;
        students.Add(student1);
        students.Add(student2);
        return View(students);
    }
    public IActionResult Vehicles()
    {
        var cars = new List<Car>() {};
        Car car1 = new Car();
        car1.Brand = "Nissan";
        car1.Model = "gtr";
        car1.MaxSpeed = 300;
        Car car2 = new Car();
        car2.Brand = "Volkswagen";
        car2.Model = "golf";
        car2.MaxSpeed = 140;
        Car car3 = new Car();
        car3.Brand = "Fiat";
        car3.Model = "punto";
        car3.MaxSpeed = 100;
        
        cars.Add(car1);
        cars.Add(car2);
        cars.Add(car3);
        return View(cars);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
