using System.Windows.Forms;
using Library.ViewModel;

namespace Library.View
{
    public partial class AllAuthorView : UserControl
    {
        private readonly MainViewModel _mainViewModel;

        public AllAuthorView(MainViewModel mainViewModel)
        {
            InitializeComponent();

            _mainViewModel = mainViewModel;
        }
    }
}
