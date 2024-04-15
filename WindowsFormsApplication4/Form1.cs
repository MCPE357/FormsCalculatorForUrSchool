using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "+";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "6";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "7";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "8";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + ".";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            string input = label1.Text;
            if (input.Contains("Sqrt"))
            {
                string pattern = @"Sqrt(\d+)";
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    double number = double.Parse(match.Groups[1].Value);
                    double sqrt = Math.Sqrt(number);
                    string replacement = sqrt.ToString();
                    string expression = Regex.Replace(input, pattern, replacement);

                    DataTable table = new DataTable();
                    table.Columns.Add("expression", typeof(double), expression);
                    DataRow row = table.NewRow();
                    table.Rows.Add(row);
                    label5.Text = expression + " = " + row["expression"];
                }

                
            }
            else
            {
                string expression = label1.Text;
                DataTable table = new DataTable();
                table.Columns.Add("expression", string.Empty.GetType(), expression);
                DataRow row = table.NewRow();
                table.Rows.Add(row);
                label5.Text = expression + " = " + double.Parse((string)row["expression"]);
            }
            
            
           
        }

        private void button4_Click(object sender, EventArgs e)
        {

            label1.Text = label1.Text + "-";
        }

        private void button3_Click(object sender, EventArgs e)
        {
             label1.Text = label1.Text + "/";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label5.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "Sqrt";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "/100";
        }

        private void button19_Click(object sender, EventArgs e)
        {

            string input = label1.Text;
            if (!string.IsNullOrEmpty(input))
            {
                string result = input.Substring(0, input.Length - 1);
                label1.Text = result;
            }
        }
    }
}
