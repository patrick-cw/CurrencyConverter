using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double conversionRate(string fromCurrency, string toCurrency)
        {
            var json = "";
            string rate = "";

            try
            {
                string url = string.Format("https://free.currconv.com/api/v7/convert?q={0}_{1}&compact=ultra&apiKey=23130c69688bb36ecf60", fromCurrency.ToUpper(), toCurrency.ToUpper());
                string key = string.Format("{0}_{1}", fromCurrency.ToUpper(), toCurrency.ToUpper());

                json = new WebClient().DownloadString(url);
                dynamic stuff = JsonConvert.DeserializeObject(json);
                rate = stuff[key];

            }
            catch 
            {
                rate = "0";
            }

            return double.Parse(rate);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                label5.Visible = true;
                label5.Text = "Choose 'TO' currency first";
                label5.ForeColor = Color.Red;
            }
            else
            if (comboBox2.SelectedItem == null)
            {
                label5.Visible = true;
                label5.Text = "Choose 'FROM' currency first";
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
                        double rate = conversionRate(comboBox2.Text, comboBox1.Text);
                        double result = double.Parse(textBox2.Text) * rate;
               

                        label5.Visible = false;
                        label6.Text = "£" + result.ToString("#0.00");
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
                        double rate = conversionRate(comboBox2.Text, comboBox1.Text);
                        double result = double.Parse(textBox2.Text) * rate;

                        label5.Visible = false;
                        label6.Text = "$" + result.ToString("#0.00");
                        label6.Visible = true;
                        label4.Visible = true;
                    }
                }
                else if (Curr == "IDR")
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
                        double rate = conversionRate(comboBox2.Text, comboBox1.Text);
                        double result = double.Parse(textBox2.Text) * rate;

                        label5.Visible = false;
                        label6.Text = "Rp" + result.ToString("#0.00");
                        label6.Visible = true;
                        label4.Visible = true;
                    }
                }
                else if (Curr == "KRW")
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
                        double rate = conversionRate(comboBox2.Text, comboBox1.Text);
                        double result = double.Parse(textBox2.Text) * rate;

                        label5.Visible = false;
                        label6.Text = "₩" + result.ToString("#0.00");
                        label6.Visible = true;
                        label4.Visible = true;
                    }
                }
                else if (Curr == "RMB")
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
                        double rate = conversionRate(comboBox2.Text, comboBox1.Text);
                        double result = double.Parse(textBox2.Text) * rate;

                        label5.Visible = false;
                        label6.Text = "元" + result.ToString("#0.00");
                        label6.Visible = true;
                        label4.Visible = true;
                    }
                }
                else if (Curr == "JPY")
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
                        double rate = conversionRate(comboBox2.Text, comboBox1.Text);
                        double result = double.Parse(textBox2.Text) * rate;

                        label5.Visible = false;
                        label6.Text = "¥" + result.ToString("#0.00");
                        label6.Visible = true;
                        label4.Visible = true;
                    }
                }
                else if (Curr == "GBP")
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
                        double rate = conversionRate(comboBox2.Text, comboBox1.Text);
                        double result = double.Parse(textBox2.Text) * rate;

                        label5.Visible = false;
                        label6.Text = "£" + result.ToString("#0.00");
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
