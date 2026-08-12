namespace SchoolTrackerApp.Models;

public class Classes
{
    public string ClassID { get; set; } = string.Empty;
    public string ClassName { get; set; } = string.Empty;
    public string Credits { get; set; } = string.Empty;
    public DateTime? StartDate { get; set; } = null;
    public DateTime? EndDate { get; set; } = null;
    public string Teacher { get; set; } = string.Empty;
    public string TeacherPhone { get; set; } = string.Empty;
    public string TeacherEmail { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;
    public string PerformanceAssessment { get; set; } = string.Empty;
    public DateTime? PAStartDate { get; set; } = null;
    public DateTime? PAEndDate { get; set; } = null;
    public bool PACompleted { get; set; } = false;
    public string ObjectiveAssessment { get; set; } = string.Empty;
    public DateTime? OAStartDate { get; set; } = null;
    public DateTime? OAEndDate { get; set; } = null;
    public bool OACompleted { get; set; } = false;
}

public class Terms
{
    public string TermID { get; set; } = string.Empty;
    public List<Classes> Classes { get; set; } = new();
}



public class DegreeRoadmap
{
    public List<Terms> Terms { get; set; } = new();
}