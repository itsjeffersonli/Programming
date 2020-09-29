using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Server=DESKTOP-5N5A115\SQLEXPRESS;" + "Database=CURD;UID=Jeff;PWD=";
            cn.Open();
          
            string query = "INSERT INTO Recipes VALUES (@ID,@Name,@Desc,@Size)";
            SqlCommand cmd = new SqlCommand(query , cn);
            cmd.Parameters.AddWithValue("@ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Desc", textBox3.Text);
            cmd.Parameters.AddWithValue("@Size", textBox4.Text);

            cmd.ExecuteNonQuery();
            cmd.Dispose();

            cn.Close();
            cn.Dispose();

            MessageBox.Show("Data Sucessfully Added");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Server=DESKTOP-5N5A115\SQLEXPRESS;" + "Database=CURD;UID=Jeff;PWD=";
            cn.Open();

            string query = "UPDATE Recipes " +
                "SET    RecipeID = @newid," +
                "       RecipeName = @Name,"+
                "       Description = @Desc,"+
                "       ServingSize = @Size" +
                "WHERE RecipeID = @ID";
            SqlCommand cmd = new SqlCommand(query, cn);

            cmd.Parameters.AddWithValue("@newid", textBox1.Text);
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Desc", textBox3.Text);
            cmd.Parameters.AddWithValue("@Size", textBox4.Text);
            cmd.Parameters.AddWithValue("@ID", newID);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cn.Close();
            cn.Dispose();
            MessageBox.Show("Edited Sucessfully");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Server=DESKTOP-5N5A115\SQLEXPRESS;" + "Database=CURD;UID=Jeff;PWD=";
            cn.Open();

            string query = "DELETE Recipes WHERE RecipeID = @ID";
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@ID", newID);
            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Dispose();
            MessageBox.Show("Deleted");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Server=DESKTOP-5N5A115\SQLEXPRESS;" + "Database=CURD;UID=Jeff;PWD=";
            cn.Open();

            string query = "SELECT * FROM Recipes";
            SqlCommand cmd = new SqlCommand(query, cn);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            cmd.Dispose();
            da.Dispose();
            cn.Close();
            cn.Dispose();
        }

        int newID = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            newID = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
        }
    }
}
