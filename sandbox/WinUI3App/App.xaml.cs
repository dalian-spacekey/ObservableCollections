using Microsoft.UI.Xaml;

namespace WinUI3App;

public partial class App
{
    public App()
    {
        InitializeComponent();
    }

    protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
    {
        window = new MainWindow();
        window.Activate();
    }

    private Window window = default!;
}