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
using WPFAppToPDF.ViewModels;

namespace WPFAppToPDF;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly MainAppViewModel _viewModel;    

    public MainWindow(MainAppViewModel viewModel)
    {
        DataContext = viewModel;
        InitializeComponent();
        _viewModel = viewModel;
        DataContext = viewModel;
    }

    private void SubmitForm_Click(object sender, RoutedEventArgs e)
    {
        _viewModel.SubmitFormToPDFCommand.Execute(this);
    }
}