using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using MVCDemoCRUD.Models;

namespace MVCDemoCRUD.Controllers
{
    public class ProductController : Controller
    {
        string connectionString = @"Data Source=.;Initial Catalog=MVCCrud;Integrated Security=True";

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
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
            // pass the data table into the View
            return View(dataTblProduct);
        }

        /// <summary>
        /// Using this action method we will return a form to enter the details of a new product
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Create()
        {
            // pass an object of the ProductModel class
            return View(new ProductModel());
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
