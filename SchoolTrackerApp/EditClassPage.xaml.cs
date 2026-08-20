using SchoolTrackerApp.Models;
#if IOS || MACCATALYST
using UserNotifications;
using Foundation;
#endif

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
            selectedClass.ClassName = cancelClassName;
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
                await DisplayAlertAsync("Error", "Please enter valid course units", "OK");
                return;
            }
            if (selectedClass.ClassID.Length > 4 )
            {
                await DisplayAlertAsync("Error", "Please enter a valid course code", "OK");
                return;
            }
            if (string.IsNullOrWhiteSpace(selectedClass.ClassName))
            {
                await DisplayAlertAsync("Error", "Class title cannot be empty", "OK");
                return;
            }
            if (string.IsNullOrWhiteSpace(selectedClass.Teacher))
            {
                await DisplayAlertAsync("Error", "Teacher name cannot be empty", "OK");
                return;
            }
            if (string.IsNullOrWhiteSpace(selectedClass.TeacherPhone))
            {
                await DisplayAlertAsync("Error", "Teacher phone cannot be empty", "OK");
                return;
            }
            if (string.IsNullOrWhiteSpace(selectedClass.TeacherEmail))
            {
                await DisplayAlertAsync("Error", "Please enter a valid Teacher Email", "OK");
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(selectedClass.TeacherEmail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                await DisplayAlertAsync("Error", "Please enter a valid Teacher Email", "OK");
                return;
            }

            ScheduleNativeAlerts(selectedClass);
        }

        await Navigation.PopAsync();
    }

 private void ScheduleNativeAlerts(Classes course)
{
    #if IOS || MACCATALYST
        UNUserNotificationCenter.Current.RequestAuthorization(
            UNAuthorizationOptions.Alert | UNAuthorizationOptions.Sound, 
            (approved, error) => {}
        );

        if (course.StartDate.HasValue && course.StartDate.Value.Year > 1 && course.StartDate.Value.Date == DateTime.Today)
        {
            var content = new UNMutableNotificationContent
            {
                Title = "Class Starting Reminder",
                Body = $"{course.ClassName} starts today!",
                Sound = UNNotificationSound.Default
            };

            var trigger = UNTimeIntervalNotificationTrigger.CreateTrigger(1, false);
            
            var request = UNNotificationRequest.FromIdentifier($"{course.ClassID}_start", content, trigger);
            UNUserNotificationCenter.Current.AddNotificationRequest(request, (err) => { });
        }

        if (course.EndDate.HasValue && course.EndDate.Value.Year > 1 && course.EndDate.Value.Date == DateTime.Today)
        {
            var content = new UNMutableNotificationContent
            {
                Title = "Class Ending Reminder",
                Body = $"{course.ClassName} concludes today.",
                Sound = UNNotificationSound.Default
            };

            var trigger = UNTimeIntervalNotificationTrigger.CreateTrigger(5, false);
            
            var request = UNNotificationRequest.FromIdentifier($"{course.ClassID}_end", content, trigger);
            UNUserNotificationCenter.Current.AddNotificationRequest(request, (err) => { });
        }
    #endif
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
