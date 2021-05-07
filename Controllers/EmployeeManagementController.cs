using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FackDataBaseCRUD.Models;
using FackDataBaseCRUD.Data;

namespace FackDataBaseCRUD.Controllers
{
    public class EmployeeManagementController : Controller
    {
        private readonly AppDbContext _context;

        //Dependency Injection. Bağımlı Enjeksiyon
        public EmployeeManagementController(AppDbContext context) //Constructure
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Employees);
        }

        //[HttpGet] -----> this workas in default without writing it.
        public IActionResult Create()
        {
            return View(); //form ----->>>>>>>model binding>>>>>>>>----------> Personel
            // will get the object from the form in our view 
            //and pass it to the other create function to be saved in the database.
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            //this function will save the passed object from the previous function into the database. 
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            // id(int) ------- LINQ   -------> Personel(referans)

            var employee = _context.Employees.SingleOrDefault(x => x.Id == id);
            return View(employee);    // form <----model binding----- Personel
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Employee _currentEmployee)  //List<string>
        {
            //remove
            //add  yanlış bir yöntem
            var _editedEmployee = _context.Employees.SingleOrDefault(x => x.Id == _currentEmployee.Id);
            //guncellenecekPersonel = personel; yanlış
            //doğru fakat uzun yöntem
            // guncellenecekPersonel.Adi = personel.Adi;
            // guncellenecekPersonel.Soyadi = personel.Soyadi;
            // guncellenecekPersonel.Resim = personel.Resim;

            await TryUpdateModelAsync(_editedEmployee);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        //method-----> Action
        public IActionResult Details(int id)
        {
            var employee = _context.Employees.Where(x => x.Id == id).SingleOrDefault();
            return View(employee);
        }

        //[HttpPost, ActionName("Delete")]
        public IActionResult Delete(int id)
        {
            //We have to add some conformation to this action.
            var employee = _context.Employees.Where(x => x.Id == id).SingleOrDefault();
            //var employee1 = _context.Employees;
            _context.Employees.Remove(employee);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }  
    }
}