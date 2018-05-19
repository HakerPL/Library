using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Library.Services;
using Library.ViewModel;
using MySQL.Entities;

namespace Library.View
{
    public partial class BorrowBookView : Form
    {
        private readonly MainViewModel _mainViewModel;
        private readonly BindingSource _readerBinding;

        public BorrowBookView(MainViewModel mainViewModel)
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

        private void tbSearchReader_TextChanged(object sender, EventArgs e)
        {
            if (tbSearchReader.Text.Length > 0)
                SearchReader();
            else
                ShowAllReader();
        }

        private void btnAddReader_Click(object sender, EventArgs e)
        {
            _mainViewModel.CourrnetReader = new Reader();

            if (!ShowReaderView())
                return;

            _mainViewModel.SaveReader.Execute(null);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void dgvReaders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(_readerBinding.Current is Reader courrent))
                return;

            _mainViewModel.CourrnetReader = courrent;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>DialogResoult</returns> return 
        private bool ShowReaderView()
        {
            ReaderView fm = new ReaderView(_mainViewModel);
            if (fm.ShowDialog() == DialogResult.Cancel)
            {
                _mainViewModel.CourrnetReader = null;
                return false;
            }

            return true;
        }

        private void SearchReader()
        {
            List<Reader> list;

            if (cbSearchOptions.SelectedIndex == 0)
                list = _mainViewModel.FiltrReader(FiltrReaderMethod.NAME, tbSearchReader.Text);
            else
                list = _mainViewModel.FiltrReader(FiltrReaderMethod.SURNAME, tbSearchReader.Text);

            _readerBinding.DataSource = list;
            dgvReaders.Refresh();
        }

        private void ShowAllReader()
        {
            _readerBinding.DataSource = _mainViewModel.GetAllReaders();
            dgvReaders.Refresh();
        }
    }
}
