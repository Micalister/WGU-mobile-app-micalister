using SchoolTrackerApp.Models;

namespace SchoolTrackerApp;

public partial class EditClassPage : ContentPage
{
    public EditClassPage(SchoolTrackerApp.Models.Classes selectedClass)
    {
        InitializeComponent();
        BindingContext = selectedClass;
    }
}