using System.Windows.Forms;
using Library.ViewModel;

namespace Library.View
{
    public partial class AuthorView : UserControl
    {
        private readonly MainViewModel _mainViewModel;

        public AuthorView(MainViewModel mainViewModel)
        {
            InitializeComponent();

            _mainViewModel = mainViewModel;
        }
    }
}
