using Microsoft.Maui.Controls;

namespace LayoustMonteros
{
    public partial class AbsoluteLayoutPage : ContentPage
    {
        public AbsoluteLayoutPage()
        {
            InitializeComponent();
        }

        private void OnGoToGridLayoutClicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}
