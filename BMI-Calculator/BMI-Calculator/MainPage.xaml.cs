using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMI_Calculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void Btn_Clicked(object sender, System.EventArgs e)
        {
            Double weight = Int32.Parse(Inp_weight.Text);
            Double height = Int32.Parse(Inp_height.Text);
            Double bmi = (weight / height / height) * 703.00;

            Lbl_BMI.Text = $"Your BMI is {bmi.ToString("F2")}.";
        }
    }
}
