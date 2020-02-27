using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Cancellations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Read data from Textboxes
            double airTemperature = txtAirTemperature.Text;
            double windChill = txtWindChill.Text;
            double numOfSnowfall = txtSnowfall.Text;

            //Retrieve current temp and display
            if(getTemperatureText(airTemperature, windChill, numOfSnowfall, out double temp, out double tempErrorMessage)) 
            {
                lblAirTemperature.Text = temp;
                lblWindChill.Text = temp;
                lblSnowfall.Text = temp;
            }
            else 
            {
                MessageBox.Show(tempErrorMessage, "Error");
            }

            txtAirTemperature.Enabled = true;
            txtWindChill.Enabled = true;
            txtSnowfall.Enabled = true;


            if (!ValidatePositiveDouble(txtAirTemperature.Text, out double airTemperature, out string tempErrorMessage))
            {
                MessageBox.Show(tempErrorMessage, "Air temperature Error");
                txtAirTemperature.Focus();
                return;

            }

            double windChill = Double.Parse(txtWindChill.Text);
            double numOfSnowfall = Double.Parse(txtSnowfall.Text);



        }
        private bool ValidatePositiveDouble(string text, out double number, out string temperrorMessage)
        {
            temperrorMessage = null;
            number = 0;

            try
            {
                number = double.Parse(text);

                if (number >= 0)
                {
                    return true;
                }
                else
                {
                    temperrorMessage = "Enter a positive number";
                    return false;
                }
            }
            catch (FormatException)
            {
                temperrorMessage = "Enter a number";
                return false;
            }

            catch (OverflowException)
            {
                temperrorMessage = "Enter a smaller number";
            }
        }

        public bool getTemperatureText(double airTemperature, double windChill, double numSnowfall, out double temperatureText, out double tempErrorMessage)
        {
            airTemperature = -25F;
            windChill = -35F;
            numOfSnowfall = 6;
            
            
            if (double.TryParse(textBox.Text, out number))
            {
                return true;
            }

            else
            {

            }
            if (txtAirTemperature.Text == "")//Checks for entry data
            {
                MessageBox.Show("Air temperature is a required field.", "Entry Error");//Displays if user did not enter data
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
