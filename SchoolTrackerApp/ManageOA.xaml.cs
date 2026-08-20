using SchoolTrackerApp.Models;
#if IOS || MACCATALYST
using UserNotifications;
using Foundation;
#endif

namespace SchoolTrackerApp;

public partial class ManageOAPage : ContentPage
{

    private readonly string cancelObjectiveAssessment;
    private readonly DateTime? cancelOAStartDate;
    private readonly DateTime? cancelOAEndDate;

    public async void ExitButton_Clicked(object sender, EventArgs e)
    {
        CancelEdit();
        await Navigation.PopAsync();
    }

    private void CancelEdit()
    {
        if (BindingContext is Classes selectedClass)
        {
            selectedClass.ObjectiveAssessment = cancelObjectiveAssessment;
            selectedClass.OAStartDate = cancelOAStartDate;
            selectedClass.OAEndDate = cancelOAEndDate;
        }
    }

    public async void SaveButtonClicked(object sender, EventArgs e)
    {
        if (BindingContext is Classes selectedClass)
        {
            if (string.IsNullOrWhiteSpace(selectedClass.ObjectiveAssessment))
            {
                await DisplayAlertAsync("Error", "Please enter valid OA Name", "OK");
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

        if (course.OAStartDate.HasValue && course.OAStartDate.Value.Year > 1 && course.OAStartDate.Value.Date == DateTime.Today)
        {
            var content = new UNMutableNotificationContent
            {
                Title = "Objective Assessment Starting Reminder",
                Body = $"{course.ObjectiveAssessment} starts today!",
                Sound = UNNotificationSound.Default
            };

            var trigger = UNTimeIntervalNotificationTrigger.CreateTrigger(1, false);
            
            var request = UNNotificationRequest.FromIdentifier($"{course.ClassID}_start", content, trigger);
            UNUserNotificationCenter.Current.AddNotificationRequest(request, (err) => { });
        }

        if (course.OAEndDate.HasValue && course.OAEndDate.Value.Year > 1 && course.OAEndDate.Value.Date == DateTime.Today)
        {
            var content = new UNMutableNotificationContent
            {
                Title = "Objective Assessment Ending Reminder",
                Body = $"{course.ObjectiveAssessment} concludes today.",
                Sound = UNNotificationSound.Default
            };

            var trigger = UNTimeIntervalNotificationTrigger.CreateTrigger(5, false);
            
            var request = UNNotificationRequest.FromIdentifier($"{course.ClassID}_end", content, trigger);
            UNUserNotificationCenter.Current.AddNotificationRequest(request, (err) => { });
        }
    #endif
}

    public ManageOAPage(SchoolTrackerApp.Models.Classes selectedClass)
    {
        InitializeComponent();
        BindingContext = selectedClass;

        cancelObjectiveAssessment = selectedClass.ObjectiveAssessment;
        cancelOAStartDate = selectedClass.OAStartDate;
        cancelOAEndDate = selectedClass.OAEndDate;
    }
}