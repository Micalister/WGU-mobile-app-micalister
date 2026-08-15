using SchoolTrackerApp.Models;

namespace SchoolTrackerApp;

public partial class EditClassPage : ContentPage
{
    public async void ExitButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
    public EditClassPage(SchoolTrackerApp.Models.Classes selectedClass)
    {
        InitializeComponent();
        BindingContext = selectedClass;
    }
}