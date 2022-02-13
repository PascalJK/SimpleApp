using Xamarin.Forms.Xaml;

namespace SimpleApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyoutPg : ContentPage
    {
        private bool _isFlyoutOpen = false;
        private readonly double _scale;
        private readonly uint _flyoutSpeed = 200;
        private readonly double _pagePositionX;
        private double _flyoutTranslationX;

        public FlyoutPg()
        {
            InitializeComponent();

            // Set page scale for both content and flyout
            _scale = MainContent.Scale;

            _pagePositionX = MainContent.TranslationX;

            // Add event listeners for SizeChanged - Allows us to capture page values after it is rendered
            MainContent.SizeChanged += OnMainContentSizeChanged;
        }

        private void OnMainContentSizeChanged(object sender, EventArgs e)
        {
            MainContent.SizeChanged -= OnMainContentSizeChanged;
            _flyoutTranslationX = MainContent.Width * .75;

            if (Flyout.Children.Count == 1 && Flyout.Children[0] is Layout menuPage)
            {
                var flyoutPadding = Flyout.Width - (Flyout.Width * .8);
                (Flyout.Children[0] as Layout).Padding = new Thickness(0, 0, flyoutPadding, 0);
            }
        }

        //Wait!
        private void OnToggleMenu(object sender, EventArgs e) => ToggleFlyout();
        private void FlyoutClose(object sender, SwipedEventArgs e) => HideFlyout();
        private void FlyoutOpen(object sender, SwipedEventArgs e) => ShowFlyout();

        private void HideFlyout()
        {
            _ = MainContent.ScaleTo(_scale, _flyoutSpeed);
            _ = MainContent.TranslateTo(_pagePositionX, Flyout.TranslationY, _flyoutSpeed);
            MainContent.Opacity = 1;
            MainContent.CornerRadius = 0;
            _isFlyoutOpen = false;
        }
        private void ShowFlyout()
        {
            _ = MainContent.ScaleTo(_scale * .9, _flyoutSpeed);
            _ = MainContent.TranslateTo(Flyout.TranslationX + _flyoutTranslationX, Flyout.TranslationY, _flyoutSpeed);
            MainContent.Opacity = 0.7;
            MainContent.CornerRadius = 25;
            _isFlyoutOpen = true;
        }

        // Dont Delete Yet!
        private void ToggleFlyout()
        {
            if (_isFlyoutOpen) HideFlyout();
            else ShowFlyout();
        }
        protected override bool OnBackButtonPressed()
        {
            bool dontClose = true;
            if (_isFlyoutOpen) HideFlyout();
            else dontClose = false;
            return dontClose;
        }
    }
}