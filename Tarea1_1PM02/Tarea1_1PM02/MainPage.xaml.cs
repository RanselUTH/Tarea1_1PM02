using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea1_1PM02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private async void btndividir_Clicked(object sender, EventArgs e)
        {
                var num = new Models.Numeros
        {
                Result = Convert.ToInt32(txtnumero1.Text) / Convert.ToInt32(txtnumero2.Text)

        };
                var page = new Views.SegundaPagina();
                page.BindingContext = num;
                await Navigation.PushAsync(page);
        }

        private async void btnsuma_Clicked(object sender, EventArgs e)
        {
            var num = new Models.Numeros
            {
                Result = Convert.ToInt32(txtnumero1.Text) + Convert.ToInt32(txtnumero2.Text)

            };
            var page = new Views.SegundaPagina();
            page.BindingContext = num;
            await Navigation.PushAsync(page);
        }

        private async void btnresta_Clicked(object sender, EventArgs e)
        {
            var num = new Models.Numeros
            {
                Result = Convert.ToInt32(txtnumero1.Text) - Convert.ToInt32(txtnumero2.Text)

            };
            var page = new Views.SegundaPagina();
            page.BindingContext = num;
            await Navigation.PushAsync(page);
        }

        private async void btnmulti_Clicked(object sender, EventArgs e)
        {
            var num = new Models.Numeros
            {
                Result = Convert.ToInt32(txtnumero1.Text) * Convert.ToInt32(txtnumero2.Text)

            };
            var page = new Views.SegundaPagina();
            page.BindingContext = num;
            await Navigation.PushAsync(page);
        }
    }
}
