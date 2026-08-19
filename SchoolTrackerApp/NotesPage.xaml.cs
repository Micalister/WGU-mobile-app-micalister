using SchoolTrackerApp.Models;

namespace SchoolTrackerApp;

public partial class NotesPage : ContentPage
{

    private readonly string cancelNotes;

    public async void ExitButton_Clicked(object sender, EventArgs e)
    {
        CancelEdit();
        await Navigation.PopAsync();
        
    }

    public async void SaveButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
    
    private void CancelEdit()
    {
        if (BindingContext is Classes selectedClass)
        {
            selectedClass.Notes = cancelNotes;
            
        }
    }

    private async void OnShareClicked(object sender, EventArgs e)
    {
        if (BindingContext is Classes selectedClass)
        {
            await Share.Default.RequestAsync(new ShareTextRequest
            {
                Title = "Share Class Notes",
                Text = selectedClass.Notes
            });
        }
    }

    public NotesPage(SchoolTrackerApp.Models.Classes selectedClass)
    {
        InitializeComponent();
        BindingContext = selectedClass;

        cancelNotes = selectedClass.Notes;

    }
}