using System.Collections.ObjectModel;

namespace TemplateSelectorHeightIssue.Controls;

public partial class ScrollControl : ContentView
{

	public ScrollControl()
	{
		InitializeComponent();
	}
}

public class Item
{
    public string Title { get; set; }
	public string Description { get; set; }
}