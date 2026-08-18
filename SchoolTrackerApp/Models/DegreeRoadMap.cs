using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SchoolTrackerApp.Models;

public class BindableModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

public class Classes : BindableModel
{
    private string _classID = string.Empty;
    private string _className = string.Empty;
    private string _credits = string.Empty;
    private DateTime? _startDate = null;
    private DateTime? _endDate = null;
    private string _teacher = string.Empty;
    private string _teacherPhone = string.Empty;
    private string _teacherEmail = string.Empty;
    private string _notes = string.Empty;
    private string _performanceAssessment = string.Empty;
    private DateTime? _pAStartDate = null;
    private DateTime? _pAEndDate = null;
    private bool _pACompleted = false;
    private string _objectiveAssessment = string.Empty;
    private DateTime? _oAStartDate = null;
    private DateTime? _oAEndDate = null;
    private bool _oACompleted = false;
    private bool _classComplete = false;

    public string ClassID { get => _classID; set { if (_classID != value) { _classID = value; OnPropertyChanged(); } } }
    public string ClassName { get => _className; set { if (_className != value) { _className = value; OnPropertyChanged(); } } }
    public string Credits { get => _credits; set { if (_credits != value) { _credits = value; OnPropertyChanged(); } } }
    public DateTime? StartDate { get => _startDate; set { if (_startDate != value) { _startDate = value; OnPropertyChanged(); } } }
    public DateTime? EndDate { get => _endDate; set { if (_endDate != value) { _endDate = value; OnPropertyChanged(); } } }
    public string Teacher { get => _teacher; set { if (_teacher != value) { _teacher = value; OnPropertyChanged(); } } }
    public string TeacherPhone { get => _teacherPhone; set { if (_teacherPhone != value) { _teacherPhone = value; OnPropertyChanged(); } } }
    public string TeacherEmail { get => _teacherEmail; set { if (_teacherEmail != value) { _teacherEmail = value; OnPropertyChanged(); } } }
    public string Notes { get => _notes; set { if (_notes != value) { _notes = value; OnPropertyChanged(); } } }
    public string PerformanceAssessment { get => _performanceAssessment; set { if (_performanceAssessment != value) { _performanceAssessment = value; OnPropertyChanged(); } } }
    public DateTime? PAStartDate { get => _pAStartDate; set { if (_pAStartDate != value) { _pAStartDate = value; OnPropertyChanged(); } } }
    public DateTime? PAEndDate { get => _pAEndDate; set { if (_pAEndDate != value) { _pAEndDate = value; OnPropertyChanged(); } } }
    public bool PACompleted { get => _pACompleted; set { if (_pACompleted != value) { _pACompleted = value; OnPropertyChanged(); } } }
    public string ObjectiveAssessment { get => _objectiveAssessment; set { if (_objectiveAssessment != value) { _objectiveAssessment = value; OnPropertyChanged(); } } }
    public DateTime? OAStartDate { get => _oAStartDate; set { if (_oAStartDate != value) { _oAStartDate = value; OnPropertyChanged(); } } }
    public DateTime? OAEndDate { get => _oAEndDate; set { if (_oAEndDate != value) { _oAEndDate = value; OnPropertyChanged(); } } }
    public bool OACompleted { get => _oACompleted; set { if (_oACompleted != value) { _oACompleted = value; OnPropertyChanged(); } } }
    public bool ClassComplete { get => _classComplete; set { if (_classComplete != value) { _classComplete = value; OnPropertyChanged(); } } }
}

public class Terms : BindableModel
{
    private string _termID = string.Empty;
    private DateTime? _termStartDate = null;
    private DateTime? _termEndDate = null;

    public string TermID { get => _termID; set { if (_termID != value) { _termID = value; OnPropertyChanged(); } } }
    public DateTime? TermStartDate { get => _termStartDate; set { if (_termStartDate != value) { _termStartDate = value; OnPropertyChanged(); } } }
    public DateTime? TermEndDate { get => _termEndDate; set { if (_termEndDate != value) { _termEndDate = value; OnPropertyChanged(); } } }
    
    public System.Collections.ObjectModel.ObservableCollection<Classes> Classes { get; set; } = new();
}

public class DegreeRoadmap : BindableModel
{
    public System.Collections.ObjectModel.ObservableCollection<Terms> Terms { get; set; } = new();
}
