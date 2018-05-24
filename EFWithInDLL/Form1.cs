using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace EFWithInDLL
{
    public partial class Form1 : Form
    {
        NORTHWNDEntities loNorthWind;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loNorthWind = new NORTHWNDEntities();
         //   MessageBox.Show(loNorthWind.Orders.ToList()); 
            List<Employee> eList= loNorthWind.Employees.ToList();
    //        MessageBox.Show(loNorthWind.Employees.SingleOrDefault(em => em.EmployeeID == 7).Country.GetType().ToString());
            comboBox1.DataSource = eList;

            comboBox1.DisplayMember = "FirstName";
        }
    }
}
