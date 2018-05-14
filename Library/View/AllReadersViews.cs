using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Library.Services;
using Library.ViewModel;
using MySQL.Entities;

namespace Library.View
{
    public partial class AllReadersViews : UserControl
    {
        private readonly MainViewModel _mainViewModel;
        private readonly BindingSource _readerBinding;

        public AllReadersViews(MainViewModel mainViewModel)
        {
            InitializeComponent();

            dgvReaders.AutoGenerateColumns = false;
            cbSearchOptions.SelectedIndex = 0;

            _mainViewModel = mainViewModel;
            _readerBinding = new BindingSource
            {
                DataSource = _mainViewModel.GetAllReaders()
            };
            dgvReaders.DataSource = _readerBinding;
        }

        private void btnShowAllReaders_Click(object sender, System.EventArgs e)
        {
            tbSearchReader.Text = "";
            _readerBinding.DataSource = _mainViewModel.GetAllReaders();
            dgvReaders.Refresh();
        }

        private void btnAddReader_Click(object sender, System.EventArgs e)
        {
            _mainViewModel.CourrnetReader = new Reader();

            if (!ShovReaderView())
                return;

            _mainViewModel.SaveReader.Execute(null);
            _readerBinding.Add(_mainViewModel.CourrnetReader);
        }

        private void btnEditReader_Click(object sender, System.EventArgs e)
        {
            if (!(_readerBinding.Current is Reader courrent))
                return;

            _mainViewModel.CourrnetReader = courrent;

            if (!ShovReaderView())
                return;

            _mainViewModel.SaveReader.Execute(null);
            dgvReaders.Refresh();
        }

        private void btnRemoveReader_Click(object sender, System.EventArgs e)
        {
            if (!(_readerBinding.Current is Reader courrent))
                return;

            _mainViewModel.CourrnetReader = courrent;
            _mainViewModel.RemoveReader.Execute(null);
            _readerBinding.RemoveCurrent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>DialogResoult</returns> return 
        private bool ShovReaderView()
        {
            ReaderView fm = new ReaderView(_mainViewModel);
            if (fm.ShowDialog() == DialogResult.Cancel)
            {
                _mainViewModel.CourrnetReader = null;
                return false;
            }

            return true;
        }

        private void dgvReaders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditReader_Click(null, null);
        }

        private void btnSearchReader_Click(object sender, System.EventArgs e)
        {
            List<Reader> list;

            if (cbSearchOptions.SelectedIndex == 0)
                list = _mainViewModel.FiltrReader(FiltrReader.NAME, tbSearchReader.Text);
            else
                list = _mainViewModel.FiltrReader(FiltrReader.SURNAME, tbSearchReader.Text);

            _readerBinding.DataSource = list;
            dgvReaders.Refresh();
        }
    }
}
