using System.Drawing;
using System.Windows.Forms;
using Library.ViewModel;
using MySQL.Entities;

namespace Library.View
{
    public partial class MainView : Form
    {
        private AllAuthorView _authorView;
        private AllBooksViews _booksViews;
        private AllReadersViews _readersViews;

        private Color _selectViewColor;
        private Color _notSelectViewColor;

        private readonly MainViewModel _mainViewModel;

        public MainView()
        {
            InitializeComponent();

            _mainViewModel = new MainViewModel();

            _selectViewColor = Color.Green;
            _notSelectViewColor = Color.White;

            CreateControls();

            btnBooks_Click(null, null);

            pView.Controls.Add(_authorView);
            pView.Controls.Add(_booksViews);
            pView.Controls.Add(_readersViews);

            _mainViewModel.RefreshView = new MainViewModel.Refresh(RefreshAllView);
        }

        private void RefreshAllView()
        {
            _authorView.RefreshView();
            _booksViews.RefreshView();
            _readersViews.RefreshView();
        }

        private void btnBooks_Click(object sender, System.EventArgs e)
        {
            SetAllControlVisibleToFalse();
            _booksViews.Visible = true;
            btnBooks.BackColor = _selectViewColor;
        }

        private void btnReaders_Click(object sender, System.EventArgs e)
        {
            SetAllControlVisibleToFalse();
            _readersViews.Visible = true;
            btnReaders.BackColor = _selectViewColor;
        }

        private void btnAuthors_Click(object sender, System.EventArgs e)
        {
            SetAllControlVisibleToFalse();
            _authorView.Visible = true;
            btnAuthors.BackColor = _selectViewColor;
        }

        private void SetAllControlVisibleToFalse()
        {
            _authorView.Visible = false;
            _booksViews.Visible = false;
            _readersViews.Visible = false;

            btnBooks.BackColor = _notSelectViewColor;
            btnReaders.BackColor = _notSelectViewColor;
            btnAuthors.BackColor = _notSelectViewColor;
        }

        private void CreateControls()
        {
            _authorView = new AllAuthorView(_mainViewModel);
            _booksViews = new AllBooksViews(_mainViewModel);
            _readersViews = new AllReadersViews(_mainViewModel);

            _authorView.Dock = DockStyle.Fill;
            _booksViews.Dock = DockStyle.Fill;
            _readersViews.Dock = DockStyle.Fill;
        }
    }
}
