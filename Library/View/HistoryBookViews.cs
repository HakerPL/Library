using System.Windows.Forms;
using Library.ViewModel;

namespace Library.View
{
    public partial class HistoryBookViews : UserControl
    {
        private readonly MainViewModel _mainViewModel;

        public HistoryBookViews(MainViewModel mainViewModel)
        {
            InitializeComponent();

            _mainViewModel = mainViewModel;
        }
    }
}
