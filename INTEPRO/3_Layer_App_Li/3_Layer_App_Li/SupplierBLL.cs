using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intepro.DataAccess;
using System.Data;

namespace Intepro.BusinessLogic
{
    class SupplierBLL
    {
        public int SupplierID { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string ContactPerson { get; set; }
        public string ContactNo { get; set; }

        private MssqlDAL dal = new MssqlDAL();

        public void Add()
        {
            dal.Open();
            dal.SetSql("INSERT INTO Suppliers VALUES (@a, @b, @c, @d, @e)");
            dal.AddParameter("@a", SupplierID);
            dal.AddParameter("@b", CompanyName);
            dal.AddParameter("@c", Address);
            dal.AddParameter("@d", ContactPerson);
            dal.AddParameter("@e", ContactNo);
            dal.Execute();
            dal.Close();
        }
        public DataTable GetAll()
        {
            dal.Open();
            dal.SetSql("SELECT * FROM Suppliers");
            DataTable dt = dal.GetData();
            dal.Close();

            return dt;
        }
        public void Delete()
        {
            dal.Open();
            dal.SetSql("DELETE Suppliers WHERE SupplierID = @id");
            dal.AddParameter("@id", SupplierID);
            dal.Execute();
            dal.Close();
        }
        public void Edit(int oldID)
        {
            dal.Open();
            dal.SetSql("UPDATE Suppliers " +
            "SET SupplierID = @id," +
            "   CompanyName = @cn," +
            "   Address = @a," +
            "   ContactPerson = @cp," +
            "   ContactNo = @cno " +
            "WHERE SupplierID = @oldID");
            dal.AddParameter("@id", SupplierID);
            dal.AddParameter("@cn", CompanyName);
            dal.AddParameter("@a", Address);
            dal.AddParameter("@cp", ContactPerson);
            dal.AddParameter("@cno", ContactNo);
            dal.AddParameter("@oldid", oldID);
            dal.Execute();
            dal.Close();
        }
        public void Validate()
        {
            if (SupplierID < 10000000 || SupplierID > 99999999)
            {
                Exception err = new Exception("SupplierID must be 8 - Digit number");
                err.Source = "Employees Business Rules";
                throw err;
            }
            if (CompanyName.Length < 5 || CompanyName.Length > 50)
            {
                Exception err = new Exception("CompanyName Length must be from 5 to 50 chars only");
                err.Source = "Employees Business Rules";
                throw err;
            }
        }
    }
}