namespace SchoolTrackerApp;

public partial class MainPage : ContentPage
{

	private async void ExpandButton_Clicked(object sender, EventArgs e)
	{
		await DisplayAlertAsync("Alert", "You clicked the button!", "OK");
	}

	public MainPage()
	{
		InitializeComponent();
	}

	
}
