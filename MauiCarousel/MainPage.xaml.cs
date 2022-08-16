namespace MauiCarousel;

public partial class MainPage : ContentPage
{	
    private readonly CarouselVM _carouselVM;

	public MainPage(CarouselVM carouselVM)
	{
        InitializeComponent();

        _carouselVM = carouselVM;
        BindingContext = _carouselVM;
        _carouselVM.AddItem();

        
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        _carouselVM.AddItem();
    }   
}

