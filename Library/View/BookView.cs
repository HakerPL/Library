using System;
using System.Windows.Forms;
using Library.Properties;
using Library.Services;
using Library.ViewModel;

namespace Library.View
{
    public partial class BookView : Form
    {
        private readonly MainViewModel _viewModel;

        public BookView(MainViewModel viewModel)
        {
            InitializeComponent();
            ControlBox = false;

            _viewModel = viewModel;

            cbBookType.DisplayMember = "Key";
            ;
            cbBookType.ValueMember = "Value";
            cbBookType.DataSource = new BindingSource(EnumToDictionary.BookType(), null);
            cbBookType.SelectedIndex = 0;

            BindingView();

            if (_viewModel.CourrnetBookBorrowed)
            {
                btnBorrow.Enabled = false;
                btnBorrow.Text = Resources.BookView_BookView_Borrowed;
            }
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
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
