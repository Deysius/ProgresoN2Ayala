using System.Threading.Tasks;
using ProgresoN2Ayala.Views;

namespace ProgresoN2Ayala
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void IrAChistes_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Chistes());

        }

        private void IrAAbout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new About());

        }
    }

}
