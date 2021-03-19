using System;
using System.Drawing;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                label5.Visible = true;
                label5.Text = "Choose the currency first";
                label5.ForeColor = Color.Red;
            }
            else
            {
                string Curr = comboBox1.SelectedItem.ToString();

                if (Curr == "EUR")
                {
                    // EUR

                    if (string.IsNullOrEmpty(textBox2.Text))
                    {
                        label5.Visible = true;
                        label5.Text = "Insert a number";
                        label5.ForeColor = Color.Red;
                    }
                    else
                    {
                        double amount = double.Parse(textBox2.Text);
                        amount = amount / 17168;

                        label5.Visible = false;
                        label6.Text = "£" + amount.ToString("#0.00");
                        label6.Visible = true;
                        label4.Visible = true;
                    }
                }
                else if (Curr == "USD")
                {
                    // USD

                    if (string.IsNullOrEmpty(textBox2.Text))
                    {
                        label5.Visible = true;
                        label5.Text = "Insert a number";
                        label5.ForeColor = Color.Red;
                    }
                    else
                    {
                        double amount = double.Parse(textBox2.Text);
                        amount = amount / 14437;

                        label5.Visible = false;
                        label6.Text = "$" + amount.ToString("#0.00");
                        label6.Visible = true;
                        label4.Visible = true;
                    }
                }
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

    }
}
