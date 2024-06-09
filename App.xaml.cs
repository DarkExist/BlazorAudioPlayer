namespace BlazorAudioPlayer
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            var window = base.CreateWindow(activationState);
            const int newWidth = 700;
            const int newHeight = 700;
            window.Width = newWidth;
            window.Height = newHeight;
            return window;
        }
    }
}
