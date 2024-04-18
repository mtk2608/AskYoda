using AskYoda.ViewModel;

namespace AskYoda.View;

public partial class babyYoda : ContentPage
{
    private YodaViewModel _viewmodel;

	public babyYoda(YodaViewModel vm)
	{
        _viewmodel = vm;

		InitializeComponent();

		BindingContext = _viewmodel;
	}
}