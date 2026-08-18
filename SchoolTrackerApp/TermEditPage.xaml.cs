using SchoolTrackerApp.Models;
using System.Runtime.CompilerServices;

namespace SchoolTrackerApp;

public partial class TermEditPage : ContentPage
{

    private readonly string cancelTermID;
    private readonly DateTime? cancelTermStartDate;
    private readonly DateTime? cancelTermEndDate;

    public async void ExitButton_Clicked(object sender, EventArgs e)
    {
        CancelEdit();
        await Navigation.PopAsync();
    }

    private void CancelEdit()
    {
        if (BindingContext is Terms currentTerm)
        {
            currentTerm.TermID = cancelTermID;
            currentTerm.TermStartDate  = cancelTermStartDate;
            currentTerm.TermEndDate  = cancelTermEndDate;
        }
    }

    private async void SaveButtonClicked(object sender, EventArgs e)
    {
        if (BindingContext is Terms currentTerm)
        {
            if (string.IsNullOrWhiteSpace(currentTerm.TermID))
            {
                await DisplayAlertAsync("Error", "The Term Title cannot be empty.", "OK");
                return;
            }
        }
        await Navigation.PopAsync();
    }

    public TermEditPage(SchoolTrackerApp.Models.Terms selectedTerm)
    {
        InitializeComponent();
        BindingContext = selectedTerm;

        cancelTermID = selectedTerm.TermID;
        cancelTermStartDate = selectedTerm.TermStartDate;
        cancelTermEndDate = selectedTerm.TermEndDate;
    }
}

