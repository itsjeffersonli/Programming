using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using SqlDataAccess;

namespace Get_Data
{
    public class data_list
    {
        public int RecordID { get; set; }
        public string RecordName { get; set; }
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string TelNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string MothersName { get; set; }
        public string MTelNumber { get; set; }


        private Sql dal = new Sql();
        public void Add()
        {
            dal.Open();
            dal.SetSql("INSERT INTO users" + "(RecordName, StudentID, Name, TelNumber, Address, Email, Username, MothersName, MTelNumber)" + "VALUES  (@a, @b, @c, @d, @e, @f, @g, @h, @i)");
            dal.AddParameter("@a", RecordName);
            dal.AddParameter("@b", StudentID);
            dal.AddParameter("@c", Name);
            dal.AddParameter("@d", TelNumber);
            dal.AddParameter("@e", Address);
            dal.AddParameter("@f", Email);
            dal.AddParameter("@g", Username);
            dal.AddParameter("@h", MothersName);
            dal.AddParameter("@i", MTelNumber);


            dal.Execute();
            dal.Close();
        }

        public List<data_list> GetAll()
        {
            List<data_list> list = new List<data_list>();
            dal.Open();
            dal.SetSql("SELECT * FROM users");
            SqlDataReader dr = dal.GetReader();
            while (dr.Read() == true)
            {
                data_list users = new data_list();
                users.RecordID = (int)dr["RecordID"];
                users.RecordName = dr["RecordName"].ToString();
                users.StudentID = (int)dr["StudentID"];
                users.Name = dr["Name"].ToString();
                users.TelNumber = dr["TelNumber"].ToString();
                users.Address = dr["Address"].ToString();
                users.Email = dr["Email"].ToString();
                users.Username = dr["Username"].ToString();
                users.MothersName = dr["MothersName"].ToString();
                users.MTelNumber = dr["MTelNumber"].ToString();
                list.Add(users);
            }
            dr.Close();
            dal.Close();

            return list;

        }
        public data_list Get(int RecordID)
        {
            data_list users = new data_list();
            dal.Open();
            dal.SetSql("SELECT * FROM users WHERE RecordID = @id");
            dal.AddParameter("@id", RecordID);
            SqlDataReader dr = dal.GetReader();
            if (dr.Read() == true)
            {
                users.RecordID = (int)dr[0];
                users.RecordName = dr[1].ToString();
                users.StudentID = (int)dr[2];
                users.Name = dr[3].ToString();
                users.TelNumber = dr[4].ToString();
                users.Address = dr[5].ToString();
                users.Email = dr[6].ToString();
                users.Username = dr[7].ToString();
                users.MothersName = dr[8].ToString();
                users.MTelNumber = dr[9].ToString();
            }
            dr.Close();
            dal.Close();
            return users;
        }

        public void Edit()
        {
            dal.Open();
            dal.SetSql("UPDATE users " +
                "SET RecordName = @Rname, " +
                "    StudentID = @SID, " +
                "    Name = @name, " +
                "    TelNumber = @number, " +
                "    Address = @address, " +
                "    Email = @email, " +
                "    Username = @username, " +
                "    MothersName = @MothersName, " +
                "    MTelNumber = @MTel " +
                "WHERE RecordID = @id");
            dal.AddParameter("@Rname", RecordName);
            dal.AddParameter("@SID", StudentID);
            dal.AddParameter("@name", Name);
            dal.AddParameter("@number", TelNumber);
            dal.AddParameter("@address", Address);
            dal.AddParameter("@email", Email);
            dal.AddParameter("@username", Username);
            dal.AddParameter("@MothersName", MothersName);
            dal.AddParameter("@MTel", MTelNumber);
            dal.AddParameter("@id", RecordID);
            dal.Execute();
            dal.Close();
        }
        public void Delete()
        {
            dal.Open();
            dal.SetSql("DELETE users WHERE RecordID = @id");
            dal.AddParameter("@id", RecordID);
            dal.Execute();
            dal.Close();
        }
    }
}