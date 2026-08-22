namespace ilfortunedinumeroneuno.Presentation;

public sealed partial class MainPage : Page
{

    public static MainPage? Current { get; private set; }
    private DispatcherTimer _snackbarTimer;

    public MainPage()
    {
        this.InitializeComponent();
        Current = this;
        InitializeTimer();

    }
    private void InitializeTimer()
    {
        _snackbarTimer = new DispatcherTimer();
        // Set snackbar duration to 3 seconds
        _snackbarTimer.Interval = TimeSpan.FromSeconds(3);
        _snackbarTimer.Tick += (s, e) =>
        {
            Snackbar.IsOpen = false;
            _snackbarTimer.Stop();
        };
    }


    public void ShowSnackbar()
    {
        // Reset the timer if it's already running from a previous click
        if (_snackbarTimer.IsEnabled)
        {
            _snackbarTimer.Stop();
        }

        // Display the Snackbar
        Snackbar.IsOpen = true;

        // Start countdown to auto-dismiss
        _snackbarTimer.Start();
    }

    private void Dimiss_Click(object sender, RoutedEventArgs e)
    {
        // Handle Action Button click
        Snackbar.IsOpen = false;
        _snackbarTimer.Stop();
    }

}
