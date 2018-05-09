using System.Windows.Forms;
using Library.ViewModel;

namespace Library.View
{
    public partial class ReadersViews : UserControl
    {
        private readonly MainViewModel _mainViewModel;

        public ReadersViews(MainViewModel mainViewModel)
        {
            InitializeComponent();

            _mainViewModel = mainViewModel;
        }
    }
}
