using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Get_Data;
using SqlDataAccess;
using Login.Models;
using System.Data.SqlClient;

namespace FINALS_INTEPRO_LI.Controllers
{
    public class UsersController : Controller
    {
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }
        public ActionResult Error()
        {
            return View();
        }
        //login

        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        void connectionString()
        {
            con.ConnectionString = @"Server=192.168.0.101\DESKTOP-A1M8536\SQLEXPRESS;" + "Database=INTEPROFINALS; UID=Jeff;PWD=";
        }
        //Login sql
        public ActionResult Verify(Account acc)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT * FROM admin WHERE username='" + acc.username + "' and password='" + acc.password + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                return View("Admin");
            }
            else
            {
                return View("Error");
            }
        }
        public ActionResult Admin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(FormCollection data)
        {
            data_list users = new data_list();
            users.RecordName = data["RecordName"];
            users.StudentID = int.Parse(data["StudentID"]);
            users.Name = data["Name"];
            users.TelNumber = data["TelNumber"];
            users.Address = data["Address"];
            users.Email = data["Email"];
            users.Username = data["Username"];
            users.MothersName = data["MothersName"];
            users.MTelNumber = data["MTelNumber"];
            users.Add();
            return RedirectToAction("Admin", "Users");
        }
        [HttpPost]
        public ActionResult Save(data_list model)
        {
            model.Add();
            return RedirectToAction("Admin", "Users");
        }
        [HttpPost]
        public ActionResult List(data_list model)
        {
            data_list user = new data_list();
            List<data_list> user_list = user.GetAll();
            return View(user_list);
        }
        public ActionResult List()
        {
            data_list user = new data_list();
            List<data_list> user_list = user.GetAll();

            return View(user_list);
        }
        public ActionResult Edit(int RecordID)
        {
            if (RecordID <= 0)         
            {
                return RedirectToAction("List", "Admin");
            }

            data_list user_list = new data_list();
            user_list = user_list.Get(RecordID);

            if (user_list.RecordID == 0)
            {
                return RedirectToAction("List", "Admin");
            }
            else
            {
                return View(user_list);
            }
        }
        [HttpPost]
        public ActionResult Edit(data_list model)
        {
            model.Edit();
            return RedirectToAction("List", "Admin");
        }


        [HttpPost]
        public ActionResult Delete(data_list model)
        {
            model.Delete();
            return RedirectToAction("List", "Users");
        }

        
    }
}