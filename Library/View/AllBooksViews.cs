using System.Windows.Forms;
using Library.ViewModel;

namespace Library.View
{
    public partial class AllBooksViews : UserControl
    {
        private readonly MainViewModel _mainViewModel;

        public AllBooksViews(ViewModel.MainViewModel mainViewModel)
        {
            InitializeComponent();

            _mainViewModel = mainViewModel;
        }
    }
}
