using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        Customer model = new Customer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            txtPlate.Text = txtCarModel.Text = txtColor.Text = txtIn.Text = txtOut.Text = "";
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            model.CustomerId = 0;
        }
    }
}
