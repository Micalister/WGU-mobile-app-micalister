using SchoolTrackerApp.Models;

namespace SchoolTrackerApp;

public partial class ManageOAPage : ContentPage
{
    public ManageOAPage(SchoolTrackerApp.Models.Classes selectedClass)
    {
        InitializeComponent();
        BindingContext = selectedClass;
    }
}