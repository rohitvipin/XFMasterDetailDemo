using Xamarin.Forms;
using XFMasterDetailDemo.ViewModels;

namespace XFMasterDetailDemo
{
    public partial class ListViewWithGrid : ContentPage
    {
        public ListViewWithGrid()
        {
            InitializeComponent();
            BindingContext = new ListViewWithGridViewModel();
        }
    }
}
