using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        double[] arr = new double[100];
        static String num = "";
        static String actions = "";
        
        

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void BT1_Click(object sender, EventArgs e)
        {
            num += '1';
            TBscreen.Text = "";
            TBscreen.AppendText(num);
        }

        private void BT2_Click(object sender, EventArgs e)
        {
            TBscreen.Text = "";
            num += '2';
            TBscreen.AppendText(num);

        }

        private void BT3_Click(object sender, EventArgs e)
        {
            TBscreen.Text = "";
            num += '3';
            TBscreen.AppendText(num);

        }

        private void BT4_Click(object sender, EventArgs e)
        {
            TBscreen.Text = "";
            num += '4';
            TBscreen.AppendText(num);

        }

        private void BT5_Click(object sender, EventArgs e)
        {
            TBscreen.Text = "";
            num += '5';
            TBscreen.AppendText(num);

        }

        private void BT6_Click(object sender, EventArgs e)
        {
            TBscreen.Text = "";
            num += '6';
            TBscreen.AppendText(num);

        }

        private void BT7_Click(object sender, EventArgs e)
        {
            TBscreen.Text = "";
            num += '7';
            TBscreen.AppendText(num);

        }

        private void BT8_Click(object sender, EventArgs e)
        {
            TBscreen.Text = "";
            num += '8';
            TBscreen.AppendText(num);

        }

        private void BT9_Click(object sender, EventArgs e)
        {
            TBscreen.Text = "";
            num += '9';
            TBscreen.AppendText(num);

        }

        private void BT0_Click(object sender, EventArgs e)
        {
            TBscreen.Text = "";
            num += '0';
            TBscreen.AppendText(num);

        }

        private void BTminus_Click(object sender, EventArgs e)
        {
            TBscreen.Text = "";
            num += '-';
            TBscreen.AppendText(num);

        }

        private void BTplus_Click(object sender, EventArgs e)
        {
            TBscreen.Text = "";
            num += '+';
            TBscreen.AppendText(num);


        }

        private void BTmul_Click(object sender, EventArgs e)
        {
            TBscreen.Text = "";
            num += '*';
            TBscreen.AppendText(num);


        }

        private void BTdivide_Click(object sender, EventArgs e)
        {
            TBscreen.Text = "";
            num += '/';
            TBscreen.AppendText(num);

        }

        private void BTequal_Click(object sender, EventArgs e)
        {
            TBscreen.AppendText("\r\n");
            add_array();
            get_actions();
            double a = arr[0];
            double b;
            for (int i = 0; i < actions.Length; i++)
            {
                b = arr[i + 1];
                switch(actions[i])
                 {
                     case '+': 
                        a = a + b; 
                        break; 
                     case '-': 
                        a = a - b; 
                        break;
                     case '*': 
                        a = a * b; 
                        break;
                     case '/': 
                        a = a / b; 
                        break;
                }
            }
            TBscreen.AppendText(a + "\r\n\r\n");
        }

        void add_array()
        {
            List<string> parts = num.Split('*','/','-','+').Select(p => p.Trim()).ToList();
            for (int i = 0; i < parts.Count; i++)
            {
                double n = Double.Parse(parts[i]);
                arr[i] = n;
            }
        }

        void get_actions ()
        {
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == '+') actions += '+';
                else if (num[i] == '-') actions += '-';
                else if (num[i] == '*') actions += '*';
                else if (num[i] == '/') actions += '/';
            }
            
        }

        private void TBscreen_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BTclear_Click(object sender, EventArgs e)
        {
            num = "";
            actions = "";
            TBscreen.Text = "";
            for (int i = 0; i < 100; i++) arr[i] = 0;
        }

        private void BTback_Click(object sender, EventArgs e)
        {
            num = num.Substring(0, num.Length - 1);
            TBscreen.Text = num;
        }

        private void BTdot_Click(object sender, EventArgs e)
        {
            num += '.';
            TBscreen.Text = "";
            TBscreen.AppendText(num);
        }
    }
}
