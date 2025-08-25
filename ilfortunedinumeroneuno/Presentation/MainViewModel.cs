using System.Net.Sockets;

namespace ilfortunedinumeroneuno.Presentation;

public partial class MainViewModel : ObservableObject
{
    private INavigator _navigator;


    internal static MySqlConnector.MySqlConnection conn = new("server=numeronesoft.ddns.net;user=guest;database=barzellette;port=3306");
    private MySqlConnector.MySqlCommand cmd;
    private MySqlConnector.MySqlDataReader reader;
    private int max = 0;
    private Random rnd;
    private int id;
    private readonly Uri HomePage = new Uri("https://www.opencode.net/numerone/Il-fortune-di-numerone");
    public String Message
    {
        get => $"Per ottenere un doppione cliccare sul pulsante \"Nuovo Biscotto\" per {max} volte.";
    }
    public string? Cookie { get; private set; }

    public bool? Continua { get; private set; }

    public async Task InfoClick()
    {
        await Windows.System.Launcher.LaunchUriAsync(HomePage);
    }
    public async Task GetCookie()
    {
        try
        {
            id = rnd.Next(1, max);
            cmd = new($"SELECT Testo FROM Barzellette WHERE ID = {id}", conn);
            reader = cmd.ExecuteReader();
            reader.Read();
            Cookie = reader.GetString(0);
            reader.Close();
            MainPage.Current?.DispatcherQueue?.TryEnqueue(() =>
            {
                OnPropertyChanged(nameof(Cookie));
            });
        }
        catch (MySqlConnector.MySqlException ex)
        {
            Cookie = ex.Message;
            Continua = false;
            MainPage.Current?.DispatcherQueue?.TryEnqueue(() =>
            {
                OnPropertyChanged(nameof(Continua));
            });
            MainPage.Current?.DispatcherQueue?.TryEnqueue(() =>
            {
                OnPropertyChanged(nameof(Cookie));
            });
        }
        catch (SocketException ex)
        {
            Cookie = ex.Message;
            Continua = false;
            MainPage.Current?.DispatcherQueue?.TryEnqueue(() =>
            {
                OnPropertyChanged(nameof(Continua));
            });
            MainPage.Current?.DispatcherQueue?.TryEnqueue(() =>
            {
                OnPropertyChanged(nameof(Cookie));
            });
        }
    }
    public MainViewModel(
        IOptions<AppConfig> appInfo,
        INavigator navigator)
    {
        _navigator = navigator;
        Title = "Il fortune di numerone uno";
        Title += $" - {appInfo?.Value?.Environment}";
        try
        {
            conn.Open();
            rnd = new();
            cmd = new("SELECT MAX(ID) FROM Barzellette", conn);
            reader = cmd.ExecuteReader();
            reader.Read();
            max = reader.GetInt32(0);
            reader.Close();
            GetCookie();
            MainPage.Current?.DispatcherQueue?.TryEnqueue(() =>
            {
                OnPropertyChanged(nameof(Cookie));
            });
        }
        catch (MySqlConnector.MySqlException ex)
        {
            Cookie = ex.Message;
            Continua = false;
            MainPage.Current?.DispatcherQueue?.TryEnqueue(() =>
            {
                OnPropertyChanged(nameof(Continua));
            });
        }
        catch (SocketException ex)
        {
            Cookie = ex.Message;
            Continua = false;
            MainPage.Current?.DispatcherQueue?.TryEnqueue(() =>
            {
                OnPropertyChanged(nameof(Continua));
            });
        }
        rnd = new();
        Click=new AsyncRelayCommand(GetCookie);
        Info=new AsyncRelayCommand(InfoClick);
    }
    public string? Title { get; }

    public ICommand Click { get; }
    public ICommand Info { get; }
}
