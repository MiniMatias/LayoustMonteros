using Microsoft.Maui.Controls;

namespace LayoustMonteros
{
    public partial class FlexLayoutPage : ContentPage
    {
        public FlexLayoutPage()
        {
            InitializeComponent();
        }

        private void OnGoToAbsoluteLayoutClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AbsoluteLayoutPage());
        }
    }
}
