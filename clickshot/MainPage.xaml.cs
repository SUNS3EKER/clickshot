using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace clickshot
{
    public partial class MainPage : ContentPage
    {
        int clicks, mejorpuntaje, ultimopuntaje;
        public int num, num2, num3;
        public bool yaperdio = false;
        public MainPage()
        {

            InitializeComponent();
            btnreiniciar.IsVisible = false;
            juego.IsVisible = false;
            lbltitulo.Text = "CLICKSHOT";
            lblup.IsVisible = false;
            lblmp.IsVisible = false;
            lblcont.IsVisible = false;
        }

        private void btnreiniciar_Clicked(object sender, EventArgs e)
        {
            btn1.BackgroundColor = Color.White;
            btn2.BackgroundColor = Color.White;
            btn3.BackgroundColor = Color.White;
            btn4.BackgroundColor = Color.White;
            btn5.BackgroundColor = Color.White;
            btn6.BackgroundColor = Color.White;
            btn7.BackgroundColor = Color.White;
            btn8.BackgroundColor = Color.White;
            btn9.BackgroundColor = Color.White;
            btn10.BackgroundColor = Color.White;
            btn11.BackgroundColor = Color.White;
            btn12.BackgroundColor = Color.White;
            btn13.BackgroundColor = Color.White;
            btn14.BackgroundColor = Color.White;
            btn15.BackgroundColor = Color.White;
            btn16.BackgroundColor = Color.White;

            seleccionadormetodos();
            seleccionadormetodos2();
            seleccionadormetodos3();
            lblcont.Text = "0";
            clicks = 0;

            juego.IsVisible = true;
            btniniciar.IsVisible = false;
            btnreiniciar.IsVisible = false;
            lbltitulo.IsVisible = false;
            lblcont.IsVisible = true;
            lblmp.IsVisible = false;
            lblup.IsVisible = false;
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            if (btn1.BackgroundColor == Color.Black)
            {
                btn1.BackgroundColor = Color.White;
                clicks += 1;
                lblcont.Text = clicks.ToString();


                seleccionadormetodos();
            }
            else
            {
                losestate();
            }
        }
        private void btn2_Clicked(object sender, EventArgs e)
        {
            if (btn2.BackgroundColor == Color.Black)
            {
                btn2.BackgroundColor = Color.White;
                clicks += 1;
                lblcont.Text = clicks.ToString();

                seleccionadormetodos2();
            }
            else
            {
                losestate();
            }
        }
        private void btn3_Clicked(object sender, EventArgs e)
        {
            if (btn3.BackgroundColor == Color.Black)
            {
                btn3.BackgroundColor = Color.White;
                clicks += 1;
                lblcont.Text = clicks.ToString();


                seleccionadormetodos3();
            }
            else
            {
                losestate();
            }
        }
        private void btn4_Clicked(object sender, EventArgs e)
        {
            if (btn4.BackgroundColor == Color.Black)
            {
                btn4.BackgroundColor = Color.White;
                clicks += 1;
                lblcont.Text = clicks.ToString();


                seleccionadormetodos();
            }
            else
            {
                losestate();
            }
        }
        private void btn5_Clicked(object sender, EventArgs e)
        {
            if (btn5.BackgroundColor == Color.Black)
            {
                btn5.BackgroundColor = Color.White;
                clicks += 1;
                lblcont.Text = clicks.ToString();


                seleccionadormetodos2();
            }
            else
            {
                losestate();
            }
        }
        private void btn6_Clicked(object sender, EventArgs e)
        {
            if (btn6.BackgroundColor == Color.Black)
            {
                btn6.BackgroundColor = Color.White;
                clicks += 1;
                lblcont.Text = clicks.ToString();



                seleccionadormetodos3();
            }
            else
            {
                losestate();
            }
        }
        private void btn7_Clicked(object sender, EventArgs e)
        {
            if (btn7.BackgroundColor == Color.Black)
            {
                btn7.BackgroundColor = Color.White;
                clicks += 1;
                lblcont.Text = clicks.ToString();

                seleccionadormetodos();

            }
            else
            {
                losestate();
            }
        }
        private void btn8_Clicked(object sender, EventArgs e)
        {
            if (btn8.BackgroundColor == Color.Black)
            {
                btn8.BackgroundColor = Color.White;
                clicks += 1;
                lblcont.Text = clicks.ToString();


                seleccionadormetodos2();
            }
            else
            {
                losestate();
            }
        }
        private void btn9_Clicked(object sender, EventArgs e)
        {
            if (btn9.BackgroundColor == Color.Black)
            {
                btn9.BackgroundColor = Color.White;
                clicks += 1;
                lblcont.Text = clicks.ToString();


                seleccionadormetodos3();
            }
            else
            {
                losestate();
            }
        }
        private void btn10_Clicked(object sender, EventArgs e)
        {
            if (btn10.BackgroundColor == Color.Black)
            {
                btn10.BackgroundColor = Color.White;
                clicks += 1;
                lblcont.Text = clicks.ToString();


                seleccionadormetodos();
            }
            else
            {
                losestate();
            }
        }
        private void btn11_Clicked(object sender, EventArgs e)
        {
            if (btn11.BackgroundColor == Color.Black)
            {
                btn11.BackgroundColor = Color.White;
                clicks += 1;
                lblcont.Text = clicks.ToString();

                seleccionadormetodos2();

            }
            else
            {
                losestate();
            }
        }
        private void btn12_Clicked(object sender, EventArgs e)
        {
            if (btn12.BackgroundColor == Color.Black)
            {
                btn12.BackgroundColor = Color.White;
                clicks += 1;
                lblcont.Text = clicks.ToString();
                seleccionadormetodos3();
            }
            else
            {
                losestate();
            }
        }
        private void btn13_Clicked(object sender, EventArgs e)
        {
            if (btn13.BackgroundColor == Color.Black)
            {
                btn13.BackgroundColor = Color.White;
                clicks += 1;
                lblcont.Text = clicks.ToString();


                seleccionadormetodos();
            }
            else
            {
                losestate();
            }
        }
        private void btn14_Clicked(object sender, EventArgs e)
        {
            if (btn14.BackgroundColor == Color.Black)
            {
                btn14.BackgroundColor = Color.White;
                clicks += 1;
                lblcont.Text = clicks.ToString();

                seleccionadormetodos2();
            }
            else
            {
                losestate();
            }
        }
        private void btn15_Clicked(object sender, EventArgs e)
        {
            if (btn15.BackgroundColor == Color.Black)
            {
                btn15.BackgroundColor = Color.White;
                clicks += 1;
                lblcont.Text = clicks.ToString();

                seleccionadormetodos3();
            }
            else
            {
                losestate();
            }
        }
        private void btn16_Clicked(object sender, EventArgs e)
        {

            if (btn16.BackgroundColor == Color.Black)
            {
                btn16.BackgroundColor = Color.White;
                clicks += 1;
                lblcont.Text = clicks.ToString();

                seleccionadormetodos();
            }
            else
            {
                losestate();
            }
        }
        private void btniniciar_Clicked(object sender, EventArgs e)
        {
            juego.IsVisible = true;
            btniniciar.IsVisible = false;
            btnreiniciar.IsVisible = false;
            lbltitulo.IsVisible = false;
            lblcont.IsVisible = true;
            lblmp.IsVisible = false;
            lblup.IsVisible = false;
            lblcredito.IsVisible = false;


            seleccionadormetodos();
            seleccionadormetodos2();
            seleccionadormetodos3();

        }

        public void losestate()
        {
            juego.IsVisible = false;
            lbltitulo.Text = "PERDISTE";
            lbltitulo.IsVisible = true;
            btnreiniciar.IsVisible = true;

            lblcont.IsVisible = false;
            lblmp.IsVisible = true;
            lblup.IsVisible = true;
            ultimopuntaje = clicks;
            lblup.Text = ("el ultimo puntaje fue: " + clicks.ToString());
            if (clicks >= mejorpuntaje)
            { mejorpuntaje = ultimopuntaje; }
            lblmp.Text = ("el mejor puntaje es: " + mejorpuntaje);
        }
        public void seleccionadormetodos()
        {
            Random random = new Random();
            num = random.Next(0, 6);

            if (num == 0) { btn1.BackgroundColor = Color.Black; }
            else if (num == 1) { btn4.BackgroundColor = Color.Black; }
            else if (num == 2) { btn7.BackgroundColor = Color.Black; }
            else if (num == 3) { btn10.BackgroundColor = Color.Black; }
            else if (num == 4) { btn13.BackgroundColor = Color.Black; }
            else if (num == 5) { btn16.BackgroundColor = Color.Black; }

        }
        public void seleccionadormetodos2()
        {
            Random random = new Random();
            num2 = random.Next(0, 5);

            if (num2 == 0) { btn2.BackgroundColor = Color.Black; }
            else if (num2 == 1) { btn5.BackgroundColor = Color.Black; }
            else if (num2 == 2) { btn8.BackgroundColor = Color.Black; }
            else if (num2 == 3) { btn11.BackgroundColor = Color.Black; }
            else if (num2 == 4) { btn14.BackgroundColor = Color.Black; }
        }
        public void seleccionadormetodos3()
        {
            Random random = new Random();
            num3 = random.Next(0, 5);

            if (num3 == 0) { btn3.BackgroundColor = Color.Black; }
            else if (num3 == 1) { btn6.BackgroundColor = Color.Black; }
            else if (num3 == 2) { btn9.BackgroundColor = Color.Black; }
            else if (num3 == 3) { btn12.BackgroundColor = Color.Black; }
            else if (num3 == 4) { btn15.BackgroundColor = Color.Black; }
        }

    }

}