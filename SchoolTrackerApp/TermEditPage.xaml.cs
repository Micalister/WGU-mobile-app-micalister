using SchoolTrackerApp.Models;
using System.Runtime.CompilerServices;

namespace SchoolTrackerApp;

public partial class TermEditPage : ContentPage
{

    public async void ExitButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    public TermEditPage(SchoolTrackerApp.Models.Terms selectedTerm)
    {
        InitializeComponent();
        BindingContext = selectedTerm;
    }
}
