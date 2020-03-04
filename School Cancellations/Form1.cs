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

        }

        public bool CheckTemp(double airTemp)
        {
            // Air temperature less than minus 25 is valid
            if (airTemp < -25)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckWindChill(double windChill)
        {
            //Wind chill less than 35 below is valid
            if (windChill < -35)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Checksnowfall(double snowfallOfInches)
        {
            //Snow falls of 6 inches or more are valid.
            if (snowfallOfInches >= 6)
            {
                return true;
            }
            else
            {
                return false;
            }
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

            return false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtAirTemperature.Text, out double airTemp) == false)
            {
                MessageBox.Show("Air temperature must be a number", "Error");
                return;
            }

            if (double.TryParse(txtSnowfall.Text, out double snowfall) == false)
            {
                MessageBox.Show("Snowfall must be positive", "Error");
                return;
            }

            if (double.TryParse(txtWindChill.Text, out double windChill) == false)
            {
                MessageBox.Show("Windchill must  be a number", "Error");
                return;
            }

            bool airTemperatureValid = CheckTemp(airTemp);//call CheckTemp method to check validation on air temperature
            if (airTemperatureValid == true)
            {
                btnTemp.Enabled = true;
                lblAirTemperature.Text = "School cancelled";
            }
            else
            {
                lblAirTemperature.Text = "School not cancelled";
            }

            bool windChillValid = CheckWindChill(windChill);
            if (windChillValid == true)
            {
                btnTemp.Enabled = true;
                lblWindChill.Text = "School cancelled";
            }
            else
            {
                lblWindChill.Text = "School not cancelled";
            }

            bool snowfallValid = Checksnowfall(snowfall);
            if (snowfallValid == true)
            {
                btnTemp.Enabled = true;
                lblSnowfall.Text = "School cancelled";
            }
            else
            {
                lblSnowfall.Text = "School not cancelled";
            }
            if (airTemperatureValid && windChillValid && snowfallValid)//Checking three conditions for valications
            {
                //Temperature button is executed because conditions are true, 
                //theredfore label controls display text such as school cancelled. 
                btnTemp.Enabled = true;
                lblAirTemperature.Text = "School cancelled";
                lblWindChill.Text = "School cancelled";
                lblSnowfall.Text = "School cancelled";
            }
            else
            {
                // Three conditions are not valid. Therefore, when temperature button is activated, label controls show " School not cancelled".
                btnTemp.Enabled = false;
                lblAirTemperature.Text = "School not cancelled";
                lblWindChill.Text = "School not cancelled";
                lblSnowfall.Text = "School not cancelled";
            }

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear text fields in text boxes
            txtAirTemperature.Text = string.Empty;
            txtWindChill.Text = string.Empty;
            txtSnowfall.Text = string.Empty;
        }
    }
}    
    

