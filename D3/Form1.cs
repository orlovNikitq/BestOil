using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace D3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox_Gasoline.SelectedIndex = 0;
            radioButton2.CheckedChanged += textBox11_TextChanged;
            radioButton1.CheckedChanged += textBox11_TextChanged;

            checkBox1.CheckedChanged += textBoxResult2_TextChanged;
            checkBox2.CheckedChanged += textBoxResult2_TextChanged;
            checkBox3.CheckedChanged += textBoxResult2_TextChanged;
            checkBox4.CheckedChanged += textBoxResult2_TextChanged;

        }

        private void comboBox_Gasoline_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedParam = comboBox_Gasoline.SelectedItem.ToString();


            switch (selectedParam)
            {
                case "АИ-80":
                    price_refill.Text = "1.23";
                    break;

                case "АИ-92":
                    price_refill.Text = "2.45";
                    break;

                case "АИ-95":
                    price_refill.Text = "3.67";
                    break;

                case "АИ-98":
                    price_refill.Text = "4.89";
                    break;
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

            float value;
            if (radioButton1.Checked)
            {
                int liters = Convert.ToInt32(textBox1.Text);
                if (float.TryParse(price_refill.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out value))
                {
                    textBoxResult1.Text = (value * liters).ToString();
                }
            }
            if (radioButton2.Checked)
            {
                int sum = Convert.ToInt32(textBox2.Text);
                textBoxResult1.Text = sum.ToString();
            }

        }

        private void textBoxResult2_TextChanged(object sender, EventArgs e)
        {
            int final = 0;
            if (checkBox1.Checked)
            {
                int price = Convert.ToInt32(textBox3.Text);
                int quantity = Convert.ToInt32(textBox7.Text);
                final += price * quantity;
            }
             
            if (checkBox2.Checked)
            {
                int price = Convert.ToInt32(textBox4.Text);
                int quantity = Convert.ToInt32(textBox8.Text);
                final += price * quantity;
            }

            if (checkBox3.Checked)
            {
                int price = Convert.ToInt32(textBox5.Text);
                int quantity = Convert.ToInt32(textBox9.Text);
                final += price * quantity;
            }

            if (checkBox4.Checked)
            {
                int price = Convert.ToInt32(textBox6.Text);
                int quantity = Convert.ToInt32(textBox10.Text);
                final += price * quantity;
            }
            textBoxResult2.Text =  final.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valueTextBox1 = 0;
            int valueTextBox2 = 0;

            if (!string.IsNullOrEmpty(textBoxResult1.Text))
            {
                if (int.TryParse(textBoxResult1.Text, out int result))
                {
                    valueTextBox1 = result;
                }
               
            }

            if (!string.IsNullOrEmpty(textBoxResult2.Text))
            {
                if (int.TryParse(textBoxResult2.Text, out int result))
                {
                    valueTextBox2 = result;
                }
            }
            int sum = valueTextBox1 + valueTextBox2;
            textBox11.Text = sum.ToString();
        }
    }
}
