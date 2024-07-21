using MauiApp1.ViewModel;

namespace MauiApp1.Views;

public partial class NotesPage : ContentPage
{
	public NotesPage()
	{
		InitializeComponent();
		BindingContext = new NotesViewModel();
	}
}