using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test
{
  

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public ObservableCollection<Sex> Sexes { get; set; } = new ObservableCollection<Sex>()
        {
            Sex.Kobieta,
            Sex.Mezczyzna
        };
        public ObservableCollection<MartialStatus> MartialStatuses { get; set; } = new ObservableCollection<MartialStatus>()
        {
            MartialStatus.Zajety,
            MartialStatus.Wolny
        };

        public RegisterPage()
        {
            InitializeComponent();
            sexEntry.ItemsSource = Sexes;
            sexEntry.SelectedIndex = 0;
            martialStatusEntry.ItemsSource = MartialStatuses;
            martialStatusEntry.SelectedIndex = 0;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}