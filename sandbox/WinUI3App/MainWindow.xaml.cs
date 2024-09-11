using Microsoft.UI.Xaml;
using ObservableCollections;

namespace WinUI3App;

public sealed partial class MainWindow
{
    private readonly ObservableDictionary<string, string> dictionary = new();
    private readonly ObservableList<string> list = new();
    private INotifyCollectionChangedSynchronizedViewList<string> ViewList { get; }

    public MainWindow()
    {
        InitializeComponent();

        dictionary.Add("Key1", "Value1");
        list.Add("Item1");

        // Dictionary�̂Ƃ��� NotifyCollectionChangedEventHandler.cs L62 �܂ōs���ė�����
        //ViewList = dictionary.ToNotifyCollectionChanged(x => x.Key);
        
        // List�̂Ƃ��͑��v
        ViewList = list.ToNotifyCollectionChanged();
    }

    private void AddButton_OnClick(object sender, RoutedEventArgs e)
    {
        dictionary.Add($"Key{dictionary.Count + 1}", $"Value{dictionary.Count + 1}");
        list.Add($"Item{dictionary.Count + 1}");
    }
}