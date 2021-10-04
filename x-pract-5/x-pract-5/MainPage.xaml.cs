using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace x_pract_5
{
    public partial class MainPage : ContentPage
    {

        double a;        
        double answer;
        int actionNumber;
        bool cinNumber = false;

        public MainPage()
        {
            InitializeComponent();            
        }

        private void btn_Clear_Clicked(object sender, EventArgs e)
        {
            a = 0;                       
            actionNumber = 0;
            ent_NumberField.Text = "";
            lbl_calcucateScreen.Text = "";
            cinNumber = false;
        }

        private void btn_DeleteOne_Clicked(object sender, EventArgs e)
        {
            if(lbl_calcucateScreen.Text.Length > 0)
            {
                lbl_calcucateScreen.Text = lbl_calcucateScreen.Text.Remove(lbl_calcucateScreen.Text.Length - 1);
                ent_NumberField.Text = ent_NumberField.Text.Remove(ent_NumberField.Text.Length - 1);                
            }            
        }

        private void btn_Percent_Clicked(object sender, EventArgs e)
        {                      
            lbl_calcucateScreen.Text = (a / 100).ToString();
            ent_NumberField.Text = (a / 100).ToString();
            cinNumber = false;
        }

        private void btn_Devide_Clicked(object sender, EventArgs e)
        {
            if(cinNumber == false)
            {
                a = Convert.ToDouble(ent_NumberField.Text);
                ent_NumberField.Text = "";
                lbl_calcucateScreen.Text += "/";
                actionNumber = 1;
                cinNumber = true;
            }            
        }

        private void btn_1_Clicked(object sender, EventArgs e)
        {
            ent_NumberField.Text += "1";
            lbl_calcucateScreen.Text += "1";
            cinNumber = false;
        }

        private void btn_2_Clicked(object sender, EventArgs e)
        {
            ent_NumberField.Text += "2";
            lbl_calcucateScreen.Text += "2";
            cinNumber = false;
        }

        private void btn_3_Clicked(object sender, EventArgs e)
        {
            ent_NumberField.Text += "3";
            lbl_calcucateScreen.Text += "3";
            cinNumber = false;
        }

        private void btn_Mult_Clicked(object sender, EventArgs e)
        {
            if(cinNumber == false)
            {
                a = Convert.ToDouble(ent_NumberField.Text);
                ent_NumberField.Text = "";
                lbl_calcucateScreen.Text += "*";
                actionNumber = 2;
                cinNumber = true;
            }            
        }

        private void btn_4_Clicked(object sender, EventArgs e)
        {
            ent_NumberField.Text += "4";
            lbl_calcucateScreen.Text += "4";
            cinNumber = false;
        }

        private void btn_5_Clicked(object sender, EventArgs e)
        {
            ent_NumberField.Text += "5";
            lbl_calcucateScreen.Text += "5";
            cinNumber = false;
        }

        private void btn_6_Clicked(object sender, EventArgs e)
        {
            ent_NumberField.Text += "6";
            lbl_calcucateScreen.Text += "6";
            cinNumber = false;
        }

        private void btn_Subtraction_Clicked(object sender, EventArgs e)
        {
            if(cinNumber == false)
            {
                a = Convert.ToDouble(ent_NumberField.Text);
                ent_NumberField.Text = "";
                lbl_calcucateScreen.Text += "-";
                actionNumber = 3;
                cinNumber = true;
            }            
        }

        private void btn_7_Clicked(object sender, EventArgs e)
        {
            ent_NumberField.Text += "7";
            lbl_calcucateScreen.Text += "7";
            cinNumber = false;
        }

        private void btn_8_Clicked(object sender, EventArgs e)
        {
            ent_NumberField.Text += "8";
            lbl_calcucateScreen.Text += "8";
            cinNumber = false;
        }

        private void btn_9_Clicked(object sender, EventArgs e)
        {
            ent_NumberField.Text += "9";
            lbl_calcucateScreen.Text += "9";
            cinNumber = false;
        }

        private void btn_Addition_Clicked(object sender, EventArgs e)
        {
            if(cinNumber  == false)
            {
                a = Convert.ToDouble(ent_NumberField.Text);
                ent_NumberField.Text = "";
                lbl_calcucateScreen.Text += "+";
                actionNumber = 4;
                cinNumber = true;
            }            
        }

        private void btn_0_Clicked(object sender, EventArgs e)
        {
            ent_NumberField.Text += "0";
            lbl_calcucateScreen.Text += "0";
            cinNumber = false;
        }

        private void btn_Dot_Clicked(object sender, EventArgs e)
        {
            if(!ent_NumberField.Text.Contains("."))
            {
                ent_NumberField.Text += ".";
                lbl_calcucateScreen.Text += ".";
            }            
        }

        private void btn_GetAnswer_Clicked(object sender, EventArgs e)
        {
            switch (actionNumber)
            {
                case 1:
                    answer = a / Convert.ToDouble(ent_NumberField.Text);
                    lbl_calcucateScreen.Text += "= " + answer.ToString();
                    ent_NumberField.Text = answer.ToString();
                    cinNumber = false;
                    break;
                case 2:
                    answer = a * Convert.ToDouble(ent_NumberField.Text);
                    lbl_calcucateScreen.Text += "= " + answer.ToString();
                    ent_NumberField.Text = answer.ToString();
                    cinNumber = false;
                    break;
                case 3:
                    answer = a - Convert.ToDouble(ent_NumberField.Text);
                    lbl_calcucateScreen.Text += "= " + answer.ToString();
                    ent_NumberField.Text = answer.ToString();
                    cinNumber = false;
                    break;
                case 4:
                    answer = a + Convert.ToDouble(ent_NumberField.Text);
                    lbl_calcucateScreen.Text += "= " + answer.ToString();
                    ent_NumberField.Text = answer.ToString();
                    cinNumber = false;
                    break;
            }
        }
    }
}
