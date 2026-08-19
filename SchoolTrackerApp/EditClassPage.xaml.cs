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