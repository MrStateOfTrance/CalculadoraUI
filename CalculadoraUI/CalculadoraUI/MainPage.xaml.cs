using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraUI
{
    public partial class MainPage : ContentPage
    {
        private float num = 0;
        private String Operacion = "";
        public MainPage()
        {
            InitializeComponent();       
        }

        

        private void btnIqual_Clicked(object sender, EventArgs e)
        {
            switch (Operacion)
            {
                case "Suma":
                    num = num + float.Parse(lblResultado.Text);
                    lblResultado.Text = num.ToString();
                    break;

                case "Resta":
                    num = num - float.Parse(lblResultado.Text);
                    lblResultado.Text = num.ToString();
                    break;

                case "Division":
                    num = num / float.Parse(lblResultado.Text);
                    lblResultado.Text = num.ToString();
                    break;

                case "Multiplicacion":
                    num = num * float.Parse(lblResultado.Text);
                    lblResultado.Text = num.ToString();
                    break;
            }

        }

        private void btnAC_Clicked(object sender, EventArgs e)
        {
            lblResultado.Text = "0";
        }
        private void btnSum_Clicked(object sender, EventArgs e)
        {
            num = float.Parse(lblResultado.Text);
            lblResultado.Text = "0";
            Operacion = "Suma";
        }

        private void btnplusmin_Clicked(object sender, EventArgs e)
        {

        }

        private void btnPercent_Clicked(object sender, EventArgs e)
        {

        }

        private void btnDiv_Clicked(object sender, EventArgs e)
        {
            num = float.Parse(lblResultado.Text);
            lblResultado.Text = "0";
            Operacion = "Division";
        }

        private void btnMin_Clicked(object sender, EventArgs e)
        {
            num = float.Parse(lblResultado.Text);
            lblResultado.Text = "0";
            Operacion = "Resta";
        }

        private void btnX_Clicked(object sender, EventArgs e)
        {
            num = float.Parse(lblResultado.Text);
            lblResultado.Text = "0";
            Operacion = "Multiplicacion";
        }

        private void btn0_Clicked(object sender, EventArgs e)
        {
            if (lblResultado.Text.StartsWith("0") && !lblResultado.Text.Contains('.'))
                lblResultado.Text = lblResultado.Text.Remove(0);

            lblResultado.Text = $"{lblResultado.Text}0";
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            if (lblResultado.Text.StartsWith("0") && !lblResultado.Text.Contains('.'))
                lblResultado.Text = lblResultado.Text.Remove(0);

            lblResultado.Text = $"{lblResultado.Text}1";
        }

        private void btn2_Clicked(object sender, EventArgs e)
        {
            if (lblResultado.Text.StartsWith("0") && !lblResultado.Text.Contains('.'))
                lblResultado.Text = lblResultado.Text.Remove(0);

            lblResultado.Text = $"{lblResultado.Text}2";
        }

        private void btn3_Clicked(object sender, EventArgs e)
        {
            if (lblResultado.Text.StartsWith("0") && !lblResultado.Text.Contains('.'))
                lblResultado.Text = lblResultado.Text.Remove(0);

            lblResultado.Text = $"{lblResultado.Text}3";
        }

        private void btn4_Clicked(object sender, EventArgs e)
        {
            if (lblResultado.Text.StartsWith("0") && !lblResultado.Text.Contains('.'))
                lblResultado.Text = lblResultado.Text.Remove(0);

            lblResultado.Text = $"{lblResultado.Text}4";
        }

        private void btn5_Clicked(object sender, EventArgs e)
        {
            if (lblResultado.Text.StartsWith("0") && !lblResultado.Text.Contains('.'))
                lblResultado.Text = lblResultado.Text.Remove(0);

            lblResultado.Text = $"{lblResultado.Text}5";
        }

        private void btn6_Clicked(object sender, EventArgs e)
        {
            if (lblResultado.Text.StartsWith("0") && !lblResultado.Text.Contains('.'))
                lblResultado.Text = lblResultado.Text.Remove(0);

            lblResultado.Text = $"{lblResultado.Text}6";
        }

        private void btn7_Clicked(object sender, EventArgs e)
        {
            if (lblResultado.Text.StartsWith("0") && !lblResultado.Text.Contains('.'))
                lblResultado.Text = lblResultado.Text.Remove(0);

            lblResultado.Text = $"{lblResultado.Text}7";
        }

        private void btn8_Clicked(object sender, EventArgs e)
        {
            if (lblResultado.Text.StartsWith("0") && !lblResultado.Text.Contains('.'))
                lblResultado.Text = lblResultado.Text.Remove(0);

            lblResultado.Text = $"{lblResultado.Text}8";
        }

        private void btn9_Clicked(object sender, EventArgs e)
        {
            if (lblResultado.Text.StartsWith("0") && !lblResultado.Text.Contains('.'))
                lblResultado.Text = lblResultado.Text.Remove(0);

            lblResultado.Text = $"{lblResultado.Text}9";
        }

        private void btnPoint_Clicked(object sender, EventArgs e)
        {
            if (!lblResultado.Text.Contains('.'))
                lblResultado.Text = $"{lblResultado.Text}.";
        }

        
    }
}
