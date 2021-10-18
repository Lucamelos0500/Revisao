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
    public partial class Detalhes : ContentPage
    {
        public Detalhes(Object animal)
        {
            if (animal == null)
                throw new ArgumentNullException();
            BindingContext = animal;
            InitializeComponent();
        }

        private void bt1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ToolbarItens());
        }
    }
}