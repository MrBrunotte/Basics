using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_fahrenheight_Click(object sender, EventArgs e)
        {
            convertFromFahrenheight();
        }

        private void btn_celcius_Click(object sender, EventArgs e)
        {
            convertFromCelcius();
        }

        private void btn_kelvin_Click(object sender, EventArgs e)
        {
            convertFromKelvin();
        }

        private void convertFromFahrenheight()
        {
            float f = 0;
            try
            {
                f = float.Parse(txt_fahrenheight.Text);
            }
            catch
            {

                MessageBox.Show("Try only numbers");
            }

            float c = 5f / 9 * (f - 32);
            float k = c - 273;

            txt_celsius.Text = c.ToString();
            txt_kelvin.Text = k.ToString();
        }


        private void convertFromCelcius()
        {
            float c = 0;

            try
            {
                c = float.Parse(txt_celsius.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Only digits please!");
            }
            float f = 9 / 5 * (c) + 32;
            float k = c + 273;

            txt_fahrenheight.Text = c.ToString();
            txt_kelvin.Text = k.ToString();
        }


        private void convertFromKelvin()
        {
            float k = 0;

            try
            {
                k = float.Parse(txt_kelvin.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Only digits please!");
            }
            float f = 9 / 5 * k + 32;
            float c = 5f / 9 * (f - 32);

            txt_fahrenheight.Text = c.ToString();
            txt_celsius.Text = f.ToString();
        }
    }
}
