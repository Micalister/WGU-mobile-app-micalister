//using SchoolTrackerApp.Models;

namespace SchoolTrackerApp;

public partial class TermDetailPage : ContentPage
{
    
    public async void ExitButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

// the Class Status Picker, temp for set up
    void OnPickerSelectedIndexChanged(object sender, EventArgs e)
{
    var picker = (Picker)sender;
    int selectedIndex = picker.SelectedIndex;

    if (selectedIndex != -1)
    {
        string ClassesStatus = picker.Items[selectedIndex];
    }
}

    public TermDetailPage(SchoolTrackerApp.Models.Terms selectedTerm)
    {   
        InitializeComponent();
        this.BindingContext = selectedTerm;
      
    }
    
}