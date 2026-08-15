namespace SchoolTrackerApp;

public partial class TermEditPage : ContentPage
{
    public TermEditPage(SchoolTrackerApp.Models.Terms selectedTerm)
    {
        InitializeComponent();
        BindingContext = selectedTerm;
    }
}
