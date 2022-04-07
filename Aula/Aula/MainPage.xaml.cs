using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Aula
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSomar_Clicked(object sender, EventArgs e)
        {
            double numero, outroNumero, resultado;

            numero = double.Parse(txtNumero.Text);
            outroNumero = double.Parse(txtOutroNumero.Text);

            resultado = numero + outroNumero;

            DisplayAlert("Resultado:", $"{numero} + {outroNumero} = {resultado}", "OK");

            
        }

        private void btnSubtrair_Clicked(object sender, EventArgs e)
        {
            double numero, outroNumero, resultado;

            numero = double.Parse(txtNumero.Text);
            outroNumero = double.Parse(txtOutroNumero.Text);

            resultado = numero - outroNumero;

            DisplayAlert("Resultado:", $"{numero} - {outroNumero} = {resultado}", "OK");

           
        }

        private void btnMultiplicar_Clicked(object sender, EventArgs e)
        {
            double numero, outroNumero, resultado;

            numero = double.Parse(txtNumero.Text);
            outroNumero = double.Parse(txtOutroNumero.Text);

            resultado = numero * outroNumero;

            DisplayAlert("Resultado:", $"{numero} X {outroNumero} = {resultado}", "OK");

            
        }

        private void btnDivisao_Clicked(object sender, EventArgs e)
        {
            double numero, outroNumero, resultado;

            numero = double.Parse(txtNumero.Text);
            outroNumero = double.Parse(txtOutroNumero.Text);

            resultado = numero / outroNumero;

            DisplayAlert("Resultado:", $"{numero} / {outroNumero} = {resultado}", "OK");

            
        }

        private void btnAreaRetangulo_Clicked(object sender, EventArgs e)
        {
            double numero, outroNumero, resultado;

            numero = double.Parse(txtNumero.Text);
            outroNumero = double.Parse(txtOutroNumero.Text);

            resultado = numero * outroNumero;

            DisplayAlert("Resultado:", $"Base {numero} Altura {outroNumero} = Area {resultado}", "OK");

            
        }

        private void btnAreaTriangulo_Clicked(object sender, EventArgs e)
        {
            double numero, outroNumero, resultado;

            numero = double.Parse(txtNumero.Text);
            outroNumero = double.Parse(txtOutroNumero.Text);

            resultado = numero * outroNumero / 2;

            DisplayAlert("Resultado:", $"Base {numero} Altura {outroNumero} = Area {resultado}", "OK");

            
        }
    }
}
