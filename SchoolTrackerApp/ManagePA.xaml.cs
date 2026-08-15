using SchoolTrackerApp.Models;

namespace SchoolTrackerApp;

public partial class ManagePAPage : ContentPage
{
    public async void ExitButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
    public ManagePAPage(SchoolTrackerApp.Models.Classes selectedClass)
    {
        InitializeComponent();
        BindingContext = selectedClass;
    }
}