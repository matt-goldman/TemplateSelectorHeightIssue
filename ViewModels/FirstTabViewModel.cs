using System.Collections.ObjectModel;

namespace TemplateSelectorHeightIssue.ViewModels;

public class FirstTabViewModel
{
    public ObservableCollection<CarouselViewModel> CarouselSections { get; set; } = new();

    public FirstTabViewModel()
    {
        AddCarouselSections();
    }

    private void AddCarouselSections()
    {
        CarouselSections.Add(new CarouselViewModel
        {
            Type = CarouselType.Grid
        });

        CarouselSections.Add(new CarouselViewModel
        {
            Type = CarouselType.Scroll,
            Items = new ObservableCollection<Controls.Item>
            {
                new Controls.Item { Title = "Sapphire Necklace", Description = "Elegant blue gemstone with a silver chain." },
                new Controls.Item { Title = "Mountain Bike", Description = "Rugged, all-terrain bicycle for adventure seekers." },
                new Controls.Item { Title = "Lemon Tea", Description = "Refreshing blend of citrus and warm tea." },
                new Controls.Item { Title = "Digital Watch", Description = "Modern timepiece with LED display." },
                new Controls.Item { Title = "Canvas Tote Bag", Description = "Durable bag for everyday essentials." },
                new Controls.Item { Title = "Acoustic Guitar", Description = "Six-stringed instrument with a wooden finish." },
                new Controls.Item { Title = "Mystery Novel", Description = "Intriguing tale of suspense and unexpected twists." },
                new Controls.Item { Title = "Potted Cactus", Description = "Low-maintenance indoor plant with thorns." },
                new Controls.Item { Title = "Wireless Earbuds", Description = "Compact audio device with Bluetooth connectivity." },
                new Controls.Item { Title = "Handmade Soap", Description = "Organic, fragrant bar for gentle cleansing." },
            }

        });
    }
}
