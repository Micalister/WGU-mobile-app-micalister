using SchoolTrackerApp.Models;
using System.Runtime.CompilerServices;

namespace SchoolTrackerApp;

public partial class TermAddPage : ContentPage
{

    //private readonly string cancelTermID;
    //private readonly DateTime? cancelTermStartDate;
    //private readonly DateTime? cancelTermEndDate;

    public async void ExitButton_Clicked(object sender, EventArgs e)
    {
        //CancelEdit();
        await Navigation.PopAsync();
    }

    /*private void CancelEdit()
    {
        if (BindingContext is Terms currentTerm)
        {
            currentTerm.TermID = cancelTermID;
            currentTerm.TermStartDate  = cancelTermStartDate;
            currentTerm.TermEndDate  = cancelTermEndDate;
        }
    }*/

    private async void SaveButtonClicked(object sender, EventArgs e)
    {
        
        await Navigation.PopAsync();
    }

    public TermAddPage()
    {
        InitializeComponent();
        //BindingContext = selectedTerm;

        //cancelTermID = selectedTerm.TermID;
        //cancelTermStartDate = selectedTerm.TermStartDate;
        //cancelTermEndDate = selectedTerm.TermEndDate;
    }
}

//SchoolTrackerApp.Models.Terms selectedTerm