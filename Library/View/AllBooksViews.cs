using System.Collections.Generic;
using System.Windows.Forms;
using Library.Services;
using Library.ViewModel;
using MySQL.Entities;

namespace Library.View
{
    public partial class AllBooksViews : UserControl
    {
        private readonly MainViewModel _mainViewModel;
        private readonly BindingSource _bookBinding;

        public AllBooksViews(MainViewModel mainViewModel)
        {
            InitializeComponent();

            dgvBooks.AutoGenerateColumns = false;
            cbSearchOptions.SelectedIndex = 0;

            _mainViewModel = mainViewModel;
            _bookBinding = new BindingSource
            {
                DataSource = _mainViewModel.GetAllBooks()
            };
            dgvBooks.DataSource = _bookBinding;
        }

        private void btnSearchBook_Click(object sender, System.EventArgs e)
        {
            List<Book> list;

            if (cbSearchOptions.SelectedIndex == 0)
                list = _mainViewModel.FiltrBook(FiltrBookMethod.TITLE, tbSearchBook.Text);
            else
                list = _mainViewModel.FiltrBook(FiltrBookMethod.ISBN, tbSearchBook.Text);

            _bookBinding.DataSource = list;
            dgvBooks.Refresh();
        }

        private void btnShowAllBooks_Click(object sender, System.EventArgs e)
        {
            tbSearchBook.Text = "";
            _bookBinding.DataSource = _mainViewModel.GetAllBooks();
            dgvBooks.Refresh();
        }

        private void btnAddBook_Click(object sender, System.EventArgs e)
        {
            _mainViewModel.CourrnetBook = new Book();

            if (!ShowReaderView())
                return;

            _mainViewModel.SaveBook.Execute(null);
            _bookBinding.Add(_mainViewModel.CourrnetBook);
        }

        private void btnEditBook_Click(object sender, System.EventArgs e)
        {
            if (!(_bookBinding.Current is Book courrent))
                return;

            _mainViewModel.CourrnetBook = courrent;

            if (!ShowReaderView())
                return;

            _mainViewModel.SaveBook.Execute(null);
            dgvBooks.Refresh();
        }

        private void btnRemoveBook_Click(object sender, System.EventArgs e)
        {
            if (!(_bookBinding.Current is Book courrent))
                return;

            _mainViewModel.CourrnetBook = courrent;
            _mainViewModel.RemoveBook.Execute(null);
            _bookBinding.RemoveCurrent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>DialogResoult</returns> return 
        private bool ShowReaderView()
        {
            BookView fm = new BookView(_mainViewModel);
            if (fm.ShowDialog() == DialogResult.Cancel)
            {
                _mainViewModel.CourrnetBook = null;
                return false;
            }

            return true;
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditBook_Click(null, null);
        }
    }
}
