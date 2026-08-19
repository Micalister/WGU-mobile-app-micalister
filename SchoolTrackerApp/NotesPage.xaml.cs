using SchoolTrackerApp.Models;

namespace SchoolTrackerApp;

public partial class NotesPage : ContentPage
{
    public async void ExitButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
    public NotesPage(SchoolTrackerApp.Models.Classes selectedClass)
    {
        InitializeComponent();
        BindingContext = selectedClass;
    }
}