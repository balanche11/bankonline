using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BankOnline.Models;
using BankOnline.ViewModels;

namespace BankOnline.Controllers
{
    public class RequestsController : Controller
    {
        private ApplicationDbContext _context;

        public RequestsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Requests
        public ActionResult Index()
        {
            
            return View(_context.Requests.Include(b => b.Customers).ToList());
        }

        // GET: Requests/Details/5
        public ActionResult Details(int? id)
        {
            
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Request request = _context.Requests.Find(id);
            if (request == null)
            {
                return HttpNotFound();
            }
            return View(request);
        }

        //GET: Requests/Create
        public ActionResult Create()
        {

            var brands = _context.Brands.ToList();
            var typeOfCards = _context.TypeOfCards.ToList();
            var viewModel = new CustomerRequestViewModel
            {
                Request = new Request(),
                Customer = new Customer(),
                Brands = brands,
                TypeOfCards = typeOfCards,

            };

            return View("Create", viewModel);
        }

        //NAMESTI KASNIJE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer, Request request)
        {
           
            if (ModelState.IsValid)
            {
                request.DateOfApplication = DateTime.Today;
                request.RequestStatus = "Pending";
                request.Commentary = "";

                _context.Customers.Add(customer);
                _context.Requests.Add(request);
                
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        //POST: Requests/Create
        //To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Id,DateOfApplication,RequestStatus,Commentary")] Request request)
        //{
        //    if (ModelState.IsValid)
        //    {

        //        _context.Requests.Add(request);
        //        _context.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(request);
        //}

        // GET: Requests/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Request request = _context.Requests.Find(id);
            if (request == null)
            {
                return HttpNotFound();
            }
            return View(request);
        }

        // POST: Requests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,DateOfApplication,RequestStatus,Commentary")] Request request)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(request).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(request);
        }

        // GET: Requests/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Request request = _context.Requests.Find(id);
            if (request == null)
            {
                return HttpNotFound();
            }
            return View(request);
        }

        // POST: Requests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Request request = _context.Requests.Find(id);
            _context.Requests.Remove(request);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
