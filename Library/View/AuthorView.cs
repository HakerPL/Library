using System;
using System.Windows.Forms;
using Library.ViewModel;

namespace Library.View
{
    public partial class AuthorView : Form
    {
        private readonly MainViewModel _viewModel;

        public AuthorView(MainViewModel viewModel)
        {
            InitializeComponent();
            ControlBox = false;

            _viewModel = viewModel;
            BindingView();
        }

        private void BindingView()
        {
            tbName.DataBindings.Add("Text", _viewModel, nameof(_viewModel.CourrnetAuthorName), true, DataSourceUpdateMode.OnPropertyChanged);
            tbSurname.DataBindings.Add("Text", _viewModel, nameof(_viewModel.CourrnetAuthorSurname), true, DataSourceUpdateMode.OnPropertyChanged);
            dtbBornDate.DataBindings.Add("Value", _viewModel, nameof(_viewModel.CourrnetAuthorBornDate), true, DataSourceUpdateMode.OnPropertyChanged);
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
