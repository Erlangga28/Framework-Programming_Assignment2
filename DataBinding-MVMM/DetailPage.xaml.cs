using DataBinding_MVMM.ViewModel;

namespace DataBinding_MVMM;

public partial class DetailPage : ContentPage
{
    public DetailPage(DetailViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}
