using System.Windows.Forms;
using Library.ViewModel;

namespace Library.View
{
    public partial class BooksViews : UserControl
    {
        private readonly MainViewModel _mainViewModel;

        public BooksViews(ViewModel.MainViewModel mainViewModel)
        {
            InitializeComponent();

            _mainViewModel = mainViewModel;
        }
    }
}
