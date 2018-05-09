using System.Windows.Forms;
using Library.ViewModel;

namespace Library.View
{
    public partial class MainView : Form
    {
        private AuthorView _authorView;
        private BooksViews _booksViews;
        private HistoryBooksViews _historyBooksViews;
        private ReadersViews _readersViews;

        private readonly MainViewModel _mainViewModel;

        public MainView()
        {
            InitializeComponent();

            _mainViewModel = new MainViewModel();

            CreateControls();
            SetAllControlVisibleToFalse();
            _authorView.Visible = true;

            pView.Controls.Add(_authorView);
            pView.Controls.Add(_booksViews);
            pView.Controls.Add(_historyBooksViews);
            pView.Controls.Add(_readersViews);
        }

        private void btnBooks_Click(object sender, System.EventArgs e)
        {
            SetAllControlVisibleToFalse();
            _booksViews.Visible = true;
        }

        private void btnHistoryBooks_Click(object sender, System.EventArgs e)
        {
            SetAllControlVisibleToFalse();
            _historyBooksViews.Visible = true;
        }

        private void btnReaders_Click(object sender, System.EventArgs e)
        {
            SetAllControlVisibleToFalse();
            _readersViews.Visible = true;
        }

        private void btnAuthors_Click(object sender, System.EventArgs e)
        {
            SetAllControlVisibleToFalse();
            _authorView.Visible = true;
        }

        private void SetAllControlVisibleToFalse()
        {
            _authorView.Visible = false;
            _booksViews.Visible = false;
            _historyBooksViews.Visible = false;
            _readersViews.Visible = false;
        }

        private void CreateControls()
        {
            _authorView = new AuthorView(_mainViewModel);
            _booksViews = new BooksViews(_mainViewModel);
            _historyBooksViews = new HistoryBooksViews(_mainViewModel);
            _readersViews = new ReadersViews(_mainViewModel);

            _authorView.Dock = DockStyle.Fill;
            _booksViews.Dock = DockStyle.Fill;
            _historyBooksViews.Dock = DockStyle.Fill;
            _readersViews.Dock = DockStyle.Fill;
        }
    }
}
