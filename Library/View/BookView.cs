using System;
using System.Windows.Forms;
using Library.Model;
using Library.Services;
using Library.ViewModel;
using MySQL.Entities;

namespace Library.View
{
    public partial class BookView : Form
    {
        private readonly MainViewModel _viewModel;
        private bool _borrowReturnSave = false;

        public BookView(MainViewModel viewModel)
        {
            InitializeComponent();

            ControlBox = false;
            dgvHistoryBook.AutoGenerateColumns = false;

            _viewModel = viewModel;

            cbBookType.DisplayMember = "Key";
            cbBookType.ValueMember = "Value";
            cbBookType.DataSource = new BindingSource(EnumToDictionary.BookType(), null);
            cbBookType.SelectedIndex = 0;

            BindingView();

            if(_viewModel.CourrnetBook.Author != null)
                tbAuthor.Text = $"{_viewModel.CourrnetBook.Author.Name} {_viewModel.CourrnetBook.Author.Surname}";

            SetViewButtonvisible();

            if (_viewModel.CourrnetBook.Id > 0)
                dgvHistoryBook.DataSource = ConvertBookHistoryToBookDto.GetBookHistory(_viewModel.CourrnetBook.Id);
        }

        private void BindingView()
        {
            tbTitle.DataBindings.Add("Text", _viewModel, nameof(_viewModel.CourrnetBookTitle), true, DataSourceUpdateMode.OnPropertyChanged);
            tbIsbn.DataBindings.Add("Text", _viewModel, nameof(_viewModel.CourrnetBookIsbn), true, DataSourceUpdateMode.OnPropertyChanged);
            dtbReleaseDate.DataBindings.Add("Value", _viewModel, nameof(_viewModel.CourrnetBookReleaseDate), true, DataSourceUpdateMode.OnPropertyChanged);
            cbBookType.DataBindings.Add("SelectedValue", _viewModel, nameof(_viewModel.CourrnetBookBookType), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!AuthorIsSet())
                return;

            _viewModel.RefreshView();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(_borrowReturnSave)
                _viewModel.SaveBook.Execute(null);

            _viewModel.RefreshView();

            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (_viewModel.CourrnetBookBorrowed)
            {
                MessageBox.Show("Book is already borrowed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!AuthorIsSet() || !BookIsInDataBase())
                return;

            _viewModel.CourrnetReader = new Reader();
            BorrowBookView assignAuthorToBook = new BorrowBookView(_viewModel);

            if (assignAuthorToBook.ShowDialog() == DialogResult.OK)
            {
                _viewModel.CourrnetBook.Borrowed = true;
                BorrowBook.Borrow(_viewModel.CourrnetBook, _viewModel.CourrnetReader);
                dgvHistoryBook.DataSource = ConvertBookHistoryToBookDto.GetBookHistory(_viewModel.CourrnetBook.Id);
                SetViewButtonvisible();

                _borrowReturnSave = true;
            }
        }

        private void btnSetAuthor_Click(object sender, EventArgs e)
        {
            _viewModel.CourrnetAuthor = new Author();
            AssignAuthorToBook assignAuthorToBook = new AssignAuthorToBook(_viewModel);

            if (assignAuthorToBook.ShowDialog() == DialogResult.OK)
            {
                _viewModel.CourrnetBook.Author = _viewModel.CourrnetAuthor;
                tbAuthor.Text = $"{_viewModel.CourrnetBook.Author.Name} {_viewModel.CourrnetBook.Author.Surname}";
            }
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            if (!_viewModel.CourrnetBookBorrowed)
            {
                MessageBox.Show("Book is already in the library", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _viewModel.CourrnetBookBorrowed = false;
            ReturnBook.ReaderReturnBook(_viewModel.CourrnetBook.Id);
            dgvHistoryBook.DataSource = ConvertBookHistoryToBookDto.GetBookHistory(_viewModel.CourrnetBook.Id);
            SetViewButtonvisible();

            _borrowReturnSave = true;
        }

        private void SetViewButtonvisible()
        {
            btnBorrow.Visible = !_viewModel.CourrnetBookBorrowed;
            btnReturnBook.Visible = _viewModel.CourrnetBookBorrowed;
        }

        private bool AuthorIsSet()
        {
            if (_viewModel.CourrnetBook.Author != null)
                return true;

            MessageBox.Show("Author is not set", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        private bool BookIsInDataBase()
        {
            if (_viewModel.CourrnetBook.Id > 0)
                return true;

            MessageBox.Show("Book is not in database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }
    }
}
