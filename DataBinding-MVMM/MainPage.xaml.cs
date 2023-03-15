using DataBinding_MVMM.ViewModel;

namespace DataBinding_MVMM;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}


