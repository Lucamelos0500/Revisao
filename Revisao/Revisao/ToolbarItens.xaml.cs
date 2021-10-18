using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Revisao
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToolbarItens : ContentPage
    {
        public ToolbarItens()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void ToolbarItem_Clicked2(object sender, EventArgs e)
        {

        }
    }
}