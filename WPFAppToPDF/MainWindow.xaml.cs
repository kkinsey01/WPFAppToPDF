using CommunityToolkit.Mvvm.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFAppToPDF.Classes;

namespace WPFAppToPDF;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
[INotifyPropertyChanged]
public partial class MainWindow : Window
{
    [ObservableProperty]
    private string email;

    [ObservableProperty]
    private string address;

    [ObservableProperty]
    private string name;


    partial void OnAddressChanged(string value)
    {
        formEntry.Address = value;
    }

    partial void OnEmailChanged(string value)
    {
        formEntry.Email = value;
    }

    partial void OnNameChanged(string value)
    {
        formEntry.Name = value;
    }

    private FormEntry formEntry;

    public MainWindow()
    {
        InitializeComponent();
        formEntry = new();
        Name = "sss";
        Email = "";
        Address = "";        
        DataContext = formEntry;
    }

    private async void SubmitForm_Click(object sender, RoutedEventArgs e)
    {
        
    }
}