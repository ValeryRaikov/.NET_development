using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class Departments : Form
    {
        Functions Con;

        public Departments()
        {
            InitializeComponent();
            Con = new Functions();
            ShowDepartments();
        }

        private void ShowDepartments()
        {
            string Query = "SELECT * FROM DepartmentTbl";
            DepList.DataSource = Con.GetData(Query);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "INSERT INTO DepartmentTbl values('{0}')";
                    Query = string.Format(Query, DepNameTb.Text);
                    Con.setData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Added!");
                    DepNameTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        int key = 0;
        private void DepList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DepNameTb.Text = DepList.SelectedItem.ToString();
            if (DepNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DepList.SelectedIndex.ToString());
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "UPDATE DepartmentTbl SET DepName = '{0}' WHERE DepId = {1}";
                    Query = string.Format(Query, DepNameTb.Text, key);
                    Con.setData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Updated!");
                    DepNameTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "DELETE FROM DepartmentTbl WHERE DepId = {0}";
                    Query = string.Format(Query, key);
                    Con.setData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Deleted!");
                    DepNameTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void EmpLbl_Click(object sender, EventArgs e)
        {
            Employees EmpObj = new Employees();
            EmpObj.Show();
            this.Hide();
        }
    }
}
