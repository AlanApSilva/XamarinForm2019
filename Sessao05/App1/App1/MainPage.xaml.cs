using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App1.Servico;
using App1.Servico.Modelo;
namespace App1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btnBuscar.Clicked += BuscarCep;
        }

        void BuscarCep(Object sender, EventArgs args) {
            string cep = txtCep.Text.Trim();

            var end =  ViaCepServico.BuscaEnderecoCep(cep);

            lblResultado.Text = string.Format("Endereço: {0}, {1} {2}", end.Localidadae, end.Uf, end.Logradouro);
        }
    }
}
