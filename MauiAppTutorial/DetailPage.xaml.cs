using MauiAppTutorial.ViewModel;

namespace MauiAppTutorial;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}