using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CASE_STUDY_BMI
{
    public partial class Form2 : Form
    {
    
        public Form2()
        {
            InitializeComponent();
            BMI_LABEL.Visible = false;
            RISK_LABEL.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1 kg = 2.2 pounds
            //12 inches = 1 foot
            //1 inch  = 0.0254 m.

            //MASS
            double kilograms;

            kilograms = Convert.ToDouble(weight.Text) / 2.2;


            //HEIGHT
            double feet, inch, meters;

            feet = Convert.ToDouble(hFeet.Text) * 12;
            inch = Convert.ToDouble(hInch.Text) + feet;

            meters = inch * 0.0254;


            double BMI = kilograms / (meters * meters);

            BMI_LABEL.Text = Convert.ToString(BMI);

            if (BMI < 18.5)
            {
                BMI_LABEL.Visible = true;
                RISK_LABEL.Visible = true;
                RISK_LABEL.Text = "Underweight";
                RISK_LABEL.ForeColor = Color.DarkRed;
            }
            else if (BMI < 25)
            {
                BMI_LABEL.Visible = true;
                RISK_LABEL.Visible = true;
                RISK_LABEL.Text = "Normal weight";
                RISK_LABEL.ForeColor = Color.Green;
            }
            else if (BMI < 30)
            {
                BMI_LABEL.Visible = true;
                RISK_LABEL.Visible = true;
                RISK_LABEL.Text = "Overweight";
                RISK_LABEL.ForeColor = Color.IndianRed;
            }
            else if (BMI >= 30)
            {
                BMI_LABEL.Visible = true;
                RISK_LABEL.Visible = true;
                RISK_LABEL.Text = "Obese";
                RISK_LABEL.ForeColor = Color.Red;
            }

        }
    }
}
