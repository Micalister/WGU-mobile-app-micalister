using SchoolTrackerApp.Models;
#if IOS || MACCATALYST
using UserNotifications;
using Foundation;
#endif

namespace SchoolTrackerApp;

public partial class ManagePAPage : ContentPage
{

    private readonly string cancelPerformanceAssessment;
    private readonly DateTime? cancelPAStartDate;
    private readonly DateTime? cancelPAEndDate;

    public async void ExitButton_Clicked(object sender, EventArgs e)
    {
        CancelEdit();
        await Navigation.PopAsync();
    }

    private void CancelEdit()
    {
        if (BindingContext is Classes selectedClass)
        {
            selectedClass.PerformanceAssessment = cancelPerformanceAssessment;
            selectedClass.PAStartDate = cancelPAStartDate;
            selectedClass.PAEndDate = cancelPAEndDate;
        }
    }

    public async void SaveButtonClicked(object sender, EventArgs e)
    {
        if (BindingContext is Classes selectedClass)
        {
            if (string.IsNullOrWhiteSpace(selectedClass.PerformanceAssessment))
            {
                await DisplayAlertAsync("Error", "Please enter valid PA Name", "OK");
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

        if (course.PAStartDate.HasValue && course.PAStartDate.Value.Year > 1 && course.PAStartDate.Value.Date == DateTime.Today)
        {
            var content = new UNMutableNotificationContent
            {
                Title = "Performance Assessment Starting Reminder",
                Body = $"{course.PerformanceAssessment} starts today!",
                Sound = UNNotificationSound.Default
            };

            var trigger = UNTimeIntervalNotificationTrigger.CreateTrigger(1, false);
            
            var request = UNNotificationRequest.FromIdentifier($"{course.ClassID}_start", content, trigger);
            UNUserNotificationCenter.Current.AddNotificationRequest(request, (err) => { });
        }

        if (course.PAEndDate.HasValue && course.PAEndDate.Value.Year > 1 && course.PAEndDate.Value.Date == DateTime.Today)
        {
            var content = new UNMutableNotificationContent
            {
                Title = "Performance Assessment Ending Reminder",
                Body = $"{course.PerformanceAssessment} concludes today.",
                Sound = UNNotificationSound.Default
            };

            var trigger = UNTimeIntervalNotificationTrigger.CreateTrigger(5, false);
            
            var request = UNNotificationRequest.FromIdentifier($"{course.ClassID}_end", content, trigger);
            UNUserNotificationCenter.Current.AddNotificationRequest(request, (err) => { });
        }
    #endif
}
    

    public ManagePAPage(SchoolTrackerApp.Models.Classes selectedClass)
    {
        InitializeComponent();
        BindingContext = selectedClass;

        cancelPerformanceAssessment = selectedClass.PerformanceAssessment;
        cancelPAStartDate = selectedClass.PAStartDate;
        cancelPAEndDate = selectedClass.PAEndDate;

    }
}