using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WPFAppToPDF.Classes;

namespace WPFAppToPDF.ViewModels;

public partial class MainAppViewModel : ObservableObject
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
    private readonly ConvertFormToPDF _convert;


    public MainAppViewModel(FormEntry formEntry, ConvertFormToPDF convert)
    {
        _convert = convert;
        this.formEntry = formEntry;
        Address = "";
        Email = "";
        Name = "";
    }

    [RelayCommand]
    public void SubmitFormToPDF()
    {        
        _convert.ConvertForm();
    }
}
