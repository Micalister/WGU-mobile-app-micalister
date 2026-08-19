using SchoolTrackerApp.Models;


namespace SchoolTrackerApp;

public partial class TermDetailPage : ContentPage
{
    
    public async void ExitButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    //Term Edit Page Button
     private async void EditTerm_Clicked(object sender, EventArgs e)
    {
        var button = sender as ImageButton;

        if (button?.BindingContext is Terms selectedTerm)
        {
            await Navigation.PushAsync(new TermEditPage(selectedTerm));
        }
    }

    // Class Edit Button

    private async void EditClass_Clicked(object sender, EventArgs e)
{
    var button = sender as ImageButton;

    if (button?.BindingContext is Classes selectedClass)
    {
        await Navigation.PushAsync(new EditClassPage(selectedClass));
    }
}

private async void NotesPage_Clicked(object sender, EventArgs e)
{
    var button = sender as ImageButton;

    if (button?.BindingContext is Classes selectedClass)
    {
        await Navigation.PushAsync(new NotesPage(selectedClass));
    }
}

// PA Edit Button
    private async void ManagePA_Clicked(object sender, EventArgs e)
    {
        var button = sender as ImageButton;

    if (button?.BindingContext is Classes selectedClass)
    {
        await Navigation.PushAsync(new ManagePAPage(selectedClass));
    }
    }

// OA Edit Button
    private async void ManageOA_Clicked(object sender, EventArgs e)
    {
        var button = sender as ImageButton;

    if (button?.BindingContext is Classes selectedClass)
    {
        await Navigation.PushAsync(new ManageOAPage(selectedClass));
    }
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