namespace LaboViews
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            Border? border = sender as Border;
            if (border is not null)
            {
                //border.BackgroundColor = Colors.DarkSlateGrey;
                await border.RotateYTo(360, 3000);
                border.RotationY = 0;
            }
        }
    }

}
