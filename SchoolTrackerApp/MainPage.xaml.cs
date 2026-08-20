using SchoolTrackerApp.Models;
using System.Collections.ObjectModel;


namespace SchoolTrackerApp;

public partial class MainPage : ContentPage
{
    // Everything is ready for C:6 for testing purposes

	public DegreeRoadmap MyRoadmap { get; set; }

	private async void ExpandButton_Clicked(object sender, EventArgs e)
	{
		var button = sender as ImageButton;

		if (button?.BindingContext is Terms selectedTerm)
		{
			await Navigation.PushAsync(new TermDetailPage(selectedTerm));
		}
	}

	public MainPage()
	{
		InitializeComponent();

		//Degree Data Structure here
		MyRoadmap = new DegreeRoadmap
		{
			Terms = new ObservableCollection<Terms>
{
    // ==========================================
    // TERM 1
    // ==========================================
    new Terms
    {
        TermID = "Term 1",
        TermStartDate = new DateTime(2026, 4, 1),
        TermEndDate = new DateTime(2026, 10, 31),
        Classes = new ObservableCollection<Classes>
        {
            new Classes
            {
                ClassID = "ORA1",
                ClassName = "Orientation",
                Credits = "0",
                StartDate = new DateTime(2026, 8, 19),
                EndDate = new DateTime(2026, 8, 20),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "Orientation must be finished during week one.",
                PerformanceAssessment = "Orientation Verification Form",
                PAStartDate = new DateTime(2026, 4, 1),
                PAEndDate = new DateTime(2026, 4, 6),
                PACompleted = false,
                ObjectiveAssessment = "System Navigation Quiz",
                OAStartDate = new DateTime(2026, 4, 1),
                OAEndDate = new DateTime(2026, 4, 7),
                OACompleted = false,
                ClassComplete = false
            },
            new Classes
            {
                ClassID = "C183",
                ClassName = "Introduction to IT",
                Credits = "4",
                StartDate = new DateTime(2026, 4, 8),
                EndDate = new DateTime(2026, 5, 15),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "Focus heavily on foundational networking schemas.",
                PerformanceAssessment = "Hardware Build Sheet Portfolio",
                PAStartDate = new DateTime(2026, 4, 15),
                PAEndDate = new DateTime(2026, 5, 1),
                PACompleted = false,
                ObjectiveAssessment = "Global IT Infrastructure Exam",
                OAStartDate = new DateTime(2026, 5, 5),
                OAEndDate = new DateTime(2026, 5, 15),
                OACompleted = false,
                ClassComplete = false
            },
            new Classes
            {
                ClassID = "C173",
                ClassName = "Scripting and Programming",
                Credits = "3",
                StartDate = new DateTime(2026, 5, 16),
                EndDate = new DateTime(2026, 6, 30),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "Practice algorithms daily on your local laptop environment.",
                PerformanceAssessment = "C++ Console Application Project",
                PAStartDate = new DateTime(2026, 5, 20),
                PAEndDate = new DateTime(2026, 6, 20),
                PACompleted = false,
                ObjectiveAssessment = "Logic and Syntax Cutoff Test",
                OAStartDate = new DateTime(2026, 6, 25),
                OAEndDate = new DateTime(2026, 6, 30),
                OACompleted = false,
                ClassComplete = false
            },
            new Classes
            {
                ClassID = "C464",
                ClassName = "Introduction to Communication",
                Credits = "3",
                StartDate = new DateTime(2026, 7, 1),
                EndDate = new DateTime(2026, 8, 15),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "Remember to record your presentation video early.",
                PerformanceAssessment = "Informative Speech Video Submission",
                PAStartDate = new DateTime(2026, 7, 10),
                PAEndDate = new DateTime(2026, 8, 1),
                PACompleted = false,
                ObjectiveAssessment = "Public Speaking Core Concepts",
                OAStartDate = new DateTime(2026, 8, 5),
                OAEndDate = new DateTime(2026, 8, 15),
                OACompleted = false,
                ClassComplete = false
            },
            new Classes
            {
                ClassID = "C779",
                ClassName = "Web Development Foundations",
                Credits = "3",
                StartDate = new DateTime(2026, 8, 16),
                EndDate = new DateTime(2026, 9, 19),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "Validate your semantic markup elements.",
                PerformanceAssessment = "Responsive CSS Landing Page Layout",
                PAStartDate = new DateTime(2026, 8, 20),
                PAEndDate = new DateTime(2026, 9, 15),
                PACompleted = false,
                ObjectiveAssessment = "HTML5 Properties and Forms Exam",
                OAStartDate = new DateTime(2026, 9, 20),
                OAEndDate = new DateTime(2026, 9, 30),
                OACompleted = false,
                ClassComplete = false
            },
            new Classes
            {
                ClassID = "C165",
                ClassName = "Integrated Physical Sciences",
                Credits = "3",
                StartDate = new DateTime(2026, 10, 1),
                EndDate = new DateTime(2026, 10, 31),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "Final course of the term, review earth sciences chapters thoroughly.",
                PerformanceAssessment = "Atmospheric Study Lab Report",
                PAStartDate = new DateTime(2026, 10, 5),
                PAEndDate = new DateTime(2026, 10, 20),
                PACompleted = false,
                ObjectiveAssessment = "Comprehensive Science Pre-assessment",
                OAStartDate = new DateTime(2026, 10, 25),
                OAEndDate = new DateTime(2026, 10, 31),
                OACompleted = false,
                ClassComplete = false
            }
        }
    }
}


			
	};
	BindingContext = this;
	
// debug lines here
	//System.Diagnostics.Debug.WriteLine("MyRoadmap Terms Count: " + MyRoadmap.Terms.Count);
	//System.Diagnostics.Debug.WriteLine("testing min date: " + MyRoadmap.Terms[0].Classes[0].StartDate);
		
	}
	

	
}
