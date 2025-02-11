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
            ListenerDepartments();
            ShowDepartments();
        }

        private void ShowDepartments()
        {

        }

        private void ListenerDepartments()
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
    }
}
