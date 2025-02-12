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
    public partial class Employees : Form
    {
        Functions Con;

        public Employees()
        {
            InitializeComponent();
            Con = new Functions();
            ShowEmployees();
            GetDepartment();
        }

        private void ShowEmployees()
        {
            string Query = "SELECT * FROM EmployeeTbl";
            EmpList.DataSource = Con.GetData(Query);
        }

        private void GetDepartment()
        {
            string Query = "SELECT * FROM DepartmentTbl";
            EmpDepCb.DisplayMember = Con.GetData(Query).Columns["DepName"].ToString();
            EmpDepCb.ValueMember = Con.GetData(Query).Columns["DepId"].ToString();
            EmpDepCb.DataSource = Con.GetData(Query);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || EmpGenderCb.SelectedIndex == -1 || EmpDepCb.SelectedIndex == -1 || SalaryTb.Text == "")
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Gender = EmpGenderCb.SelectedItem.ToString();
                    int Department = Convert.ToInt32(EmpDepCb.SelectedValue.ToString());
                    string DOB = DOBTb.Value.ToString();
                    string JDate = JDateTb.Value.ToString();
                    int Salary = Convert.ToInt32(SalaryTb.Text);

                    string Query = "INSERT INTO EmployeeTbl values('{0}', '{1}', {2}, '{3}', '{4}', {5})";
                    Query = string.Format(Query, Name, Gender, Department, DOB, JDate, Salary);
                    Con.setData(Query);
                    ShowEmployees();
                    MessageBox.Show("Employee Added!");

                    EmpNameTb.Text = "";
                    SalaryTb.Text = "";
                    EmpGenderCb.SelectedIndex = -1;
                    EmpDepCb.SelectedIndex = -1;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || EmpGenderCb.SelectedIndex == -1 || EmpDepCb.SelectedIndex == -1 || SalaryTb.Text == "")
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Gender = EmpGenderCb.SelectedItem.ToString();
                    int Department = Convert.ToInt32(EmpDepCb.SelectedValue.ToString());
                    string DOB = DOBTb.Value.ToString();
                    string JDate = JDateTb.Value.ToString();
                    int Salary = Convert.ToInt32(SalaryTb.Text);

                    string Query = "UPDATE EmployeeTbl SET EmpName = '{0}', EmpGender = '{1}', EmpDepartment = {2}, " +
                        "EmpDateOfBirth = '{3}', EmpJoinDate = '{4}', EmpSalary = {5}) WHERE EmpId = {6}";
                    Query = string.Format(Query, Name, Gender, Department, DOB, JDate, Salary, key);
                    Con.setData(Query);
                    ShowEmployees();
                    MessageBox.Show("Employee Updated!");

                    EmpNameTb.Text = "";
                    SalaryTb.Text = "";
                    EmpGenderCb.SelectedIndex = -1;
                    EmpDepCb.SelectedIndex = -1;
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
                if (key == 0)
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    string Query = "DELETE FROM EmployeeTbl WHERE EmpId = {0}";
                    Query = string.Format(Query, key);
                    Con.setData(Query);
                    ShowEmployees();
                    MessageBox.Show("Employee Deleted!");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        int key = 0;
        private void EmpList_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmpNameTb.Text = EmpList.SelectedItem.ToString();
            if (EmpNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(EmpList.SelectedIndex.ToString());
            }
        }
    }
}
