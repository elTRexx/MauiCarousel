using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Maui;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiCarousel
{
    public partial class CarouselVM : ObservableObject
    {
        private ObservableCollection<string> _carouselItems = new();
        public ObservableCollection<string> CarouselItems { get => _carouselItems; set => SetProperty(ref _carouselItems, value); }
        static int _carouselCount = 0;

        public void AddItem()
        {
            _carouselCount++;

            if (CarouselItems.Count != 0)
                CarouselItems.Clear();

            for (int i = 0; i< _carouselCount; i++)
            {
                CarouselItems.Add($"Item #{i}");
            }

            //OnPropertyChanged(nameof(CarouselItems));
        }        
    }
}
