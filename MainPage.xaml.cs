using Microsoft.Maui.Controls;

namespace LayoustMonteros
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnGoToStackLayoutClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StackLayoutPage());
        }
    }
}
