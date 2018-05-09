using System.Windows.Forms;
using Library.ViewModel;

namespace Library.View
{
    public partial class HistoryBooksViews : UserControl
    {
        private readonly MainViewModel _mainViewModel;

        public HistoryBooksViews(MainViewModel mainViewModel)
        {
            InitializeComponent();

            _mainViewModel = mainViewModel;
        }
    }
}
