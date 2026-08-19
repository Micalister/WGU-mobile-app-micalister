using SchoolTrackerApp.Models;
using System.Collections.ObjectModel;


namespace SchoolTrackerApp;

public partial class MainPage : ContentPage
{
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
        TermStartDate = new DateTime(2022, 4, 1),
        TermEndDate = new DateTime(2022, 10, 31),
        Classes = new ObservableCollection<Classes>
        {
            new Classes
            {
                ClassID = "C183",
                ClassName = "Introduction to IT",
                Credits = "4",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
                OACompleted = false,
                ClassComplete = false
            },
            new Classes
            {
                ClassID = "C173",
                ClassName = "Scripting and Programming",
                Credits = "3",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
                OACompleted = false,
                ClassComplete = false
            },
            new Classes
            {
                ClassID = "ORA1",
                ClassName = "Orientation",
                Credits = "0",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
                OACompleted = false,
                ClassComplete = false
            },
            new Classes
            {
                ClassID = "C464",
                ClassName = "Introduction to Communication",
                Credits = "3",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
                OACompleted = false,
                ClassComplete = false
            },
            new Classes
            {
                ClassID = "C779",
                ClassName = "Web Development Foundations",
                Credits = "3",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
                OACompleted = false,
                ClassComplete = false
            },
            new Classes
            {
                ClassID = "C165",
                ClassName = "Integrated Physical Sciences",
                Credits = "3",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
                OACompleted = false,
                ClassComplete = false
            }
        }
    },


        // ==========================================
    // TERM 2
    // ==========================================
    new Terms
    {
        TermID = "Term 2",
        TermStartDate = new DateTime(1, 1, 1),
        TermEndDate = new DateTime(1, 1, 1),
        Classes = new ObservableCollection<Classes>
        {
            new Classes
            {
                ClassID = "C393",
                ClassName = "IT Foundations",
                Credits = "4",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
                OACompleted = false,
                ClassComplete = false
            },
            new Classes
            {
                ClassID = "C955",
                ClassName = "Applied Probability and Statistics",
                Credits = "4",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
                OACompleted = false,
                ClassComplete = false
            },
            new Classes
            {
                ClassID = "C768",
                ClassName = "Technical Communication",
                Credits = "3",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
                OACompleted = false,
                ClassComplete = false
            },
            new Classes
            {
                ClassID = "C394",
                ClassName = "IT Applications",
                Credits = "4",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
                OACompleted = false,
                ClassComplete = false
            },
            new Classes
            {
                ClassID = "D315",
                ClassName = "Network and Security - Foundations",
                Credits = "3",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
                OACompleted = false,
                ClassComplete = false
            },
            new Classes
            {
                ClassID = "C963",
                ClassName = "American Politics and the US Constitution",
                Credits = "3",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
                OACompleted = false,
                ClassComplete = false
            }
        }
    },


	    // ==========================================
    // TERM 3
    // ==========================================
    new Terms
    {
        TermID = "Term 3",
        TermStartDate = new DateTime(1, 1, 1),
        TermEndDate = new DateTime(1, 1, 1),
        Classes = new ObservableCollection<Classes>
        {
            new Classes
            {
                ClassID = "426",
                ClassName = "Data Management - Foundations",
                Credits = "3",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
                OACompleted = false,
                ClassComplete = false
            },
            new Classes
            {
                ClassID = "D427",
                ClassName = "Data Management - Applications",
                Credits = "4",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
                OACompleted = false,
                ClassComplete = false
            },
            new Classes
            {
                ClassID = "D197",
                ClassName = "Version Control",
                Credits = "1",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
                OACompleted = false,
                ClassComplete = false
            },
            new Classes
            {
                ClassID = "D270",
                ClassName = "Composition: Successful Self-Expression",
                Credits = "3",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
                OACompleted = false,
                ClassComplete = false
            },
            new Classes
            {
                ClassID = "D199",
                ClassName = "Introduction to Physical and Human Geography",
                Credits = "3",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
                OACompleted = false,
                ClassComplete = false
            },
            new Classes
            {
                ClassID = "D277",
                ClassName = "Front-End Web Development",
                Credits = "3",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
                OACompleted = false,
                ClassComplete = false
            }
        }
    },

    // ==========================================
    // TERM 4
    // ==========================================
    new Terms
    {
        TermID = "Term 4",
        TermStartDate = new DateTime(1, 1, 1),
        TermEndDate = new DateTime(1, 1, 1),
        Classes = new ObservableCollection<Classes>
        {
            new Classes
            {
                ClassID = "D370",
                ClassName = "IT Leadership Foundations",
                Credits = "3",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
                OACompleted = false,
                ClassComplete = false
            },
            new Classes
            {
                ClassID = "D333",
                ClassName = "Ethics in Technology",
                Credits = "3",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
                OACompleted = false,
                ClassComplete = false
            },
            new Classes
            {
                ClassID = "D373",
                ClassName = "Introduction to Systems Thinking",
                Credits = "3",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
                OACompleted = false,
                ClassComplete = false
            },
            new Classes
            {
                ClassID = "D282",
                ClassName = "Cloud Foundations",
                Credits = "3",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
                OACompleted = false,
                ClassComplete = false
            },
            new Classes
            {
                ClassID = "C957",
                ClassName = "Applied Algebra",
                Credits = "3",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
                OACompleted = false,
                ClassComplete = false
            },
            new Classes
            {
                ClassID = "D280",
                ClassName = "JavaScript Programming",
                Credits = "3",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
                OACompleted = false,
                ClassComplete = false
            }
        }
    },
    // ==========================================
    // TERM 5
    // ==========================================
    new Terms
    {
        TermID = "Term 5",
        TermStartDate = new DateTime(1, 1, 1),
        TermEndDate = new DateTime(1, 1, 1),
        Classes = new ObservableCollection<Classes>
        {
            new Classes
            {
                ClassID = "D326",
                ClassName = "Advanced Data Management",
                Credits = "3",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
                OACompleted = false,
                ClassComplete = false
            },
            new Classes
            {
                ClassID = "D279",
                ClassName = "User Interface Design",
                Credits = "3",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
                OACompleted = false,
                ClassComplete = false
            },
            new Classes
            {
                ClassID = "D479",
                ClassName = "User Experience Design",
                Credits = "3",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
                OACompleted = false,
                ClassComplete = false
            },
            new Classes
            {
                ClassID = "D324",
                ClassName = "Business of IT - Project Management",
                Credits = "4",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
                OACompleted = false,
                ClassComplete = false
            },
            new Classes
            {
                ClassID = "D336",
                ClassName = "Business of IT - Application",
                Credits = "4",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
                OACompleted = false,
                ClassComplete = false
            },
            new Classes
            {
                ClassID = "D335",
                ClassName = "Introduction to Programming in Python",
                Credits = "3",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
                OACompleted = false,
                ClassComplete = false
            }
        }
    },
    // ==========================================
    // TERM 6
    // ==========================================
    new Terms
    {
        TermID = "Term 6",
        TermStartDate = new DateTime(1, 1, 1),
        TermEndDate = new DateTime(1, 1, 1),
        Classes = new ObservableCollection<Classes>
        {
            new Classes
            {
                ClassID = "C949",
                ClassName = "Data Structures and Algorithms I",
                Credits = "4",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
                OACompleted = false,
                ClassComplete = false
            },
            new Classes
            {
                ClassID = "C968",
                ClassName = "Software I - C#",
                Credits = "6",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
                OACompleted = false,
                ClassComplete = false
            },
            new Classes
            {
                ClassID = "D284",
                ClassName = "Software Engineering",
                Credits = "4",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
                OACompleted = false,
                ClassComplete = false
            },
            new Classes
            {
                ClassID = "D480",
                ClassName = "Software Design and Quality Assurance",
                Credits = "3",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
                OACompleted = false,
                ClassComplete = false
            },
            new Classes
            {
                ClassID = "D385",
                ClassName = "Software Security and Testing",
                Credits = "3",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
                OACompleted = false,
                ClassComplete = false
            },
            new Classes
            {
                ClassID = "C969",
                ClassName = "Software II - Advanced C#",
                Credits = "6",
                StartDate = new DateTime(1, 1, 1),
                EndDate = new DateTime(1, 1, 1),
                Teacher = "Anika Patel",
                TeacherPhone = "555-123-4567",
                TeacherEmail = "anika.patel@strimeuniversity.edu",
                Notes = "to be filled",
                PerformanceAssessment = "to be filled",
                PAStartDate = new DateTime(1, 1, 1),
                PAEndDate = new DateTime(1, 1, 1),
                PACompleted = false,
                ObjectiveAssessment = "to be filled",
                OAStartDate = new DateTime(1, 1, 1),
                OAEndDate = new DateTime(1, 1, 1),
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
