using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace MVCDemoCRUD.Controllers
{
    public class ProductController : Controller
    {
        string connectionString = @"Data Source=.;Initial Catalog=MVCCrud;Integrated Security=True";
        [HttpGet]
        public ActionResult Index()
        {
            // create new data table
            DataTable dataTblProduct = new DataTable();
            // declare the sql connection object and pass in the connection string
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                // open the sql connection and create the sql data adapter with the query
                sqlCon.Open();
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter("SELECT * FROM Product", sqlCon);
                // now fill the results from the quert into the data table
                sqlDataAdap.Fill(dataTblProduct);
            }
            return View(dataTblProduct);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
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

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
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

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
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
