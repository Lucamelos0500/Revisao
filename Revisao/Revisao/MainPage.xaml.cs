using Revisao.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Revisao
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            listview.ItemsSource = new List<Animal>
            {
              new Animal { nome="Crocodilo",
                    tipo="Carnívoro",
                    peso=1200,
                    altura=7,
                    sexo="macho",
                    caracteristica="Maior réptil aquático.",
                    imagem ="img/crocodilo.jpg" },
              new Animal { nome="Raposa",
                    tipo="Carnívoro",
                    peso=7,
                    altura=35,
                    sexo="fêmea",
                    caracteristica="Predador do ártico.",
                    imagem ="img/raposa.jpg" },
              new Animal { nome="Baleia Orca",
                    tipo="Carnívoro",
                    peso=11,
                    altura=8,
                    sexo="macho",
                    caracteristica="Maior golfinho existente.",
                    imagem ="img/orca.jpg" }
            };
        }

        private void listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var animal = e.SelectedItem as Animal;
            Detail = new NavigationPage(new Detalhes(animal));
            IsPresented = false;
        }
    }
}