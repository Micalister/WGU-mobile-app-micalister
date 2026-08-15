using SchoolTrackerApp.Models;

namespace SchoolTrackerApp;

public partial class ManagePAPage : ContentPage
{
    public ManagePAPage(SchoolTrackerApp.Models.Classes selectedClass)
    {
        InitializeComponent();
        BindingContext = selectedClass;
    }
}