using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Activity3_Li.Data;
using Activity3_Li.Models;

namespace Activity3_Li.Controllers
{
    public class SupplierController : Controller
    {
        private readonly ApplicationDBContext _context;

        public SupplierController(ApplicationDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var list = _context.Suppliers.ToList();
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Supplier record)
        {
            var item = new Supplier();
            {
                item.CompanyName = record.CompanyName;
                item.Representative = record.Representative;
                item.Code = record.Code;
                item.Address = record.Address;
                item.DateAdded = record.DateAdded;
                item.Types = record.Types;
            };

            _context.Suppliers.Add(item);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var item = _context.Suppliers.Where(i => i.SupplierID == id).SingleOrDefault();
            if (item == null)
            {
                return RedirectToAction("Index");
            }
            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(int? id, Supplier record)
        {
            var item = _context.Suppliers.Where(i => i.SupplierID == id).SingleOrDefault();

            item.CompanyName = record.CompanyName;
            item.Representative = record.Representative;
            item.Code = record.Code;
            item.Address = record.Address;
            item.DateModified = DateTime.Now;
            item.Types = record.Types;

            _context.Suppliers.Update(item);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var item = _context.Suppliers.Where(i => i.SupplierID == id).SingleOrDefault();
            if (item == null)
            {
                return RedirectToAction("Index");
            }
            _context.Suppliers.Remove(item);
            _context.SaveChanges();
            return View(item);
        }
    }
   }
