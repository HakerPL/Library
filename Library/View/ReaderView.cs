using System;
using System.Windows.Forms;
using Library.Model;
using Library.ViewModel;

namespace Library.View
{
    public partial class ReaderView : Form
    {
        private readonly MainViewModel _viewModel;

        public ReaderView(MainViewModel viewModel)
        {
            InitializeComponent();
            ControlBox = false;

            _viewModel = viewModel;
            BindingView();

            if (_viewModel.CourrnetReader.Id > 0)
                dgvHistoryReader.DataSource = ConvertBookHistoryToReaderDto.GetReaderHistory(_viewModel.CourrnetReader.Id);
        }

        private void BindingView()
        {
            tbName.DataBindings.Add("Text", _viewModel, nameof(_viewModel.CourrnetReaderName), true, DataSourceUpdateMode.OnPropertyChanged);
            tbSurname.DataBindings.Add("Text", _viewModel, nameof(_viewModel.CourrnetReaderSurname), true, DataSourceUpdateMode.OnPropertyChanged);
            dtbBornDate.DataBindings.Add("Value", _viewModel, nameof(_viewModel.CourrnetReaderBornDate), true, DataSourceUpdateMode.OnPropertyChanged);
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
