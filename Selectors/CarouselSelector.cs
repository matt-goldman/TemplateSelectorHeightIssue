using TemplateSelectorHeightIssue.ViewModels;

namespace TemplateSelectorHeightIssue.Selectors;

public class CarouselSelector : DataTemplateSelector
{
    public DataTemplate Scroll { get; set; }
    public DataTemplate Grid { get; set; }

    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        var vm = (CarouselViewModel)item;

        return vm.Type == CarouselType.Scroll ? Scroll : Grid;
    }
}
