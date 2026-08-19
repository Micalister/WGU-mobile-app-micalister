using SchoolTrackerApp.Models;

namespace SchoolTrackerApp;

public partial class ManageOAPage : ContentPage
{
    public async void ExitButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    public async void SaveButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
    
    public ManageOAPage(SchoolTrackerApp.Models.Classes selectedClass)
    {
        InitializeComponent();
        BindingContext = selectedClass;
    }
}