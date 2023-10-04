using TemplateSelectorHeightIssue.ViewModels;

namespace TemplateSelectorHeightIssue.Pages;

public partial class FirstTab : ContentPage
{
	public FirstTab(FirstTabViewModel viewModel)
	{
		InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }

    public FirstTabViewModel _viewModel { get; set; }
}