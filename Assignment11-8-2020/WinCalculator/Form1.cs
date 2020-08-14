using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassCalcLib;

namespace WinCalculator
{
    public partial class Form1 : Form
    {
        Operators obj;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            obj = new Operators();
            obj.num1 = Convert.ToInt32(txtNum1.Text);
            obj.num2 = Convert.ToInt32(txtNum2.Text);
            lblres.Text = obj.Add().ToString();




        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            obj = new Operators();
            obj.num1 = Convert.ToInt32(txtNum1.Text);
            obj.num2 = Convert.ToInt32(txtNum2.Text);
            lblres.Text = obj.Multiply().ToString();

        }

        private void btnQuotient_Click(object sender, EventArgs e)
        {
            obj = new Operators();
            obj.num1 = Convert.ToInt32(txtNum1.Text);
            obj.num2 = Convert.ToInt32(txtNum2.Text);
            lblres.Text = obj.Divide().ToString();

        }

        private void btnModulus_Click(object sender, EventArgs e)
        {
            obj = new Operators();
            obj.num1 = Convert.ToInt32(txtNum1.Text);
            obj.num2 = Convert.ToInt32(txtNum2.Text);
            lblres.Text = obj.Modulus().ToString();

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            obj = new Operators();
            obj.num1 = Convert.ToInt32(txtNum1.Text);
            obj.num2 = Convert.ToInt32(txtNum2.Text);
            lblres.Text = obj.Subtract().ToString();
        }
    }
}
