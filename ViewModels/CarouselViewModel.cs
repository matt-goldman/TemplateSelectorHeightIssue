using System.Collections.ObjectModel;
using TemplateSelectorHeightIssue.Controls;

namespace TemplateSelectorHeightIssue.ViewModels;

public class CarouselViewModel
{
    public CarouselType Type { get; set; }

    public ObservableCollection<Item> Items { get; set; }
}

public enum CarouselType
{
    Scroll,
    Grid
}
