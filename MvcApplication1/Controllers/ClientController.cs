using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class ClientController : Controller
    {
        //
        // GET: /Client/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Client/Details/5

        public ActionResult Details(int id)
        {
            var client =GetClientInfofromRepository(id);

            return View(client);
        }

        private Client GetClientInfofromRepository(int id)
        {
            //this info can come from xml or database or wherever
            switch (id)
            {
                case 1:
                    return new Client {ColumnHeading1="fullname",ColumnHeading2="some id",ColumnHeading3="xyx" };
                    break;
                case 2:
                    return new Client { ColumnHeading1 = "first name last", ColumnHeading2 = "some ixd", ColumnHeading3 = "xyz" };
                    break;
                default:
                    return new Client { ColumnHeading1 = "name", ColumnHeading2 = "somey id", ColumnHeading3 = "xkx" };
                    break;
            }

        }

        //
        // GET: /Client/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Client/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Client/Edit/5
 
        public ActionResult Edit(int id)
        {
            
            return View();
        }

        //
        // POST: /Client/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Client/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Client/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
