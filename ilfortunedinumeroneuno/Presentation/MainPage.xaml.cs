namespace ilfortunedinumeroneuno.Presentation;

public sealed partial class MainPage : Page
{

    public static MainPage? Current { get; private set; }
    public MainPage()
    {
        this.InitializeComponent();
        Current = this;
    }
}
