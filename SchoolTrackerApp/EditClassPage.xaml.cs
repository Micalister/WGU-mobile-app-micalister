using SchoolTrackerApp.Models;

namespace SchoolTrackerApp;

public partial class EditClassPage : ContentPage
{

    private readonly string cancelCredits;
    private readonly string cancelClassID;
    private readonly string cancelClassName;
    private readonly DateTime? cancelStartDate;
    private readonly DateTime? cancelEndDate;
    private readonly string cancelTeacher;
    private readonly string cancelTeacherPhone;
    private readonly string cancelTeacherEmail;

    public async void ExitButton_Clicked(object sender, EventArgs e)
    {
        CancelEdit();
        await Navigation.PopAsync();
    }

    private void CancelEdit()
    {
        if (BindingContext is Classes selectedClass)
        {
            selectedClass.Credits = cancelCredits;
            selectedClass.ClassID = cancelClassID;
            selectedClass.ClassID = cancelClassName;
            selectedClass.StartDate  = cancelStartDate;
            selectedClass.EndDate  = cancelEndDate;
            selectedClass.Teacher  = cancelTeacher;
            selectedClass.TeacherPhone  = cancelTeacherPhone;
            selectedClass.TeacherEmail  = cancelTeacherEmail;
        }
    }

    private async void SaveButtonClicked(object sender, EventArgs e)
    {

        if (BindingContext is Classes selectedClass)
        {
            if (string.IsNullOrWhiteSpace(selectedClass.Credits) || selectedClass.Credits.Length > 1 || !int.TryParse(selectedClass.Credits, out int result))
            {
                await DisplayAlertAsync("Error", "Please enter a valid course units", "OK");
                return;
            }
            else if (selectedClass.ClassID.Length > 4 )
            {
                await DisplayAlertAsync("Error", "Please enter a valid course code", "OK");
                return;
            }
            else if (string.IsNullOrWhiteSpace(selectedClass.ClassName))
            {
                await DisplayAlertAsync("Error", "Class title cannot be empty", "OK");
                return;
            }
            else if (string.IsNullOrWhiteSpace(selectedClass.Teacher))
            {
                await DisplayAlertAsync("Error", "Teacher name cannot be empty", "OK");
                return;
            }
            else if (string.IsNullOrWhiteSpace(selectedClass.TeacherPhone))
            {
                await DisplayAlertAsync("Error", "Teacher phone cannot be empty", "OK");
                return;
            }
            else if (string.IsNullOrWhiteSpace(selectedClass.TeacherEmail))
            {
                await DisplayAlertAsync("Error", "Pls enter a valid Teacher Email", "OK");
                return;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(selectedClass.TeacherEmail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                await DisplayAlertAsync("Error", "Please enter a valid Teacher Email", "OK");
                return;
            }
        }

        await Navigation.PopAsync();
    }
    public EditClassPage(SchoolTrackerApp.Models.Classes selectedClass)
    {
        InitializeComponent();
        BindingContext = selectedClass;

        cancelCredits = selectedClass.Credits;
        cancelClassID = selectedClass.ClassID;
        cancelClassName = selectedClass.ClassName;
        cancelStartDate = selectedClass.StartDate;
        cancelEndDate = selectedClass.EndDate;
        cancelTeacher = selectedClass.Teacher;
        cancelTeacherPhone = selectedClass.TeacherPhone;
        cancelTeacherEmail = selectedClass.TeacherEmail;
    }
}