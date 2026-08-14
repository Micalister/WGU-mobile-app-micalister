//using SchoolTrackerApp.Models;

namespace SchoolTrackerApp;

public partial class TermDetailPage : ContentPage
{
    
    public async void ExitButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    public TermDetailPage(SchoolTrackerApp.Models.Terms selectedTerm)
    {   
        InitializeComponent();
        this.BindingContext = selectedTerm;
      
    }
    
}