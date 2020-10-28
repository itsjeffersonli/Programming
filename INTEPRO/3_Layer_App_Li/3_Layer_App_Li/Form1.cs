using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Intepro.BusinessLogic;

namespace _3_Layer_App_Li
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SupplierBLL emp = new SupplierBLL();
        private void button2_Click(object sender, EventArgs e)
        {
            dgvSuppliers.DataSource = emp.GetAll();
        }
        private void ResetControls()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            button2_Click(new object(), new EventArgs());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetControls();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                emp.SupplierID = int.Parse(textBox1.Text);
                emp.CompanyName = textBox2.Text;
                emp.Address = textBox3.Text;
                emp.ContactPerson = textBox4.Text;
                emp.ContactNo = textBox5.Text;
                emp.Validate();
                emp.Add();

                MessageBox.Show("Add Record Successful!");
                ResetControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }

        }
        private int empID = 0;

        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dgvSuppliers.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dgvSuppliers.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dgvSuppliers.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dgvSuppliers.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dgvSuppliers.SelectedRows[0].Cells[4].Value.ToString();
            empID = (int)dgvSuppliers.SelectedRows[0].Cells[0].Value;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            emp.SupplierID = empID;
            emp.Delete();

            MessageBox.Show("Delete Record Successful!");
            ResetControls();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            emp.SupplierID = int.Parse(textBox1.Text);
            emp.CompanyName = textBox2.Text;
            emp.Address = textBox3.Text;
            emp.ContactPerson = textBox4.Text;
            emp.ContactNo = textBox5.Text;
            emp.Edit(empID);

            MessageBox.Show("Edit Record Successful!");
            ResetControls();

        }
    }
}
