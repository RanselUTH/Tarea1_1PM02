using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea1_1PM02.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SegundaPagina : ContentPage
    {

        public SegundaPagina()
        {
            InitializeComponent();
        }
        public SegundaPagina(String pmessage)
        {
            InitializeComponent();

            lbResult.Text = pmessage;
        }
    }
}