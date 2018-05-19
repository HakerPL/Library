using MySQL.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Library.Services;
using Library.ViewModel;

namespace Library.View
{
    public partial class AssignAuthorToBook : Form
    {
        private readonly MainViewModel _mainViewModel;
        private readonly BindingSource _authorBinding;

        public AssignAuthorToBook(MainViewModel mainViewModel)
        {
            InitializeComponent();

            dgvAuthors.AutoGenerateColumns = false;
            cbSearchOptions.SelectedIndex = 0;

            _mainViewModel = mainViewModel;
            _authorBinding = new BindingSource
            {
                DataSource = _mainViewModel.GetAllAuthors()
            };
            dgvAuthors.DataSource = _authorBinding;
        }

        private void tbSearchAuthor_TextChanged(object sender, EventArgs e)
        {
            if (tbSearchAuthor.Text.Length > 0)
                SearchAuthor();
            else
                ShowAllAuthor();
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            _mainViewModel.CourrnetAuthor = new Author();

            if (!ShowAuthorView())
                return;

            _mainViewModel.SaveAuthor.Execute(null);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void dgvAuthors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(_authorBinding.Current is Author courrent))
                return;

            _mainViewModel.CourrnetAuthor = courrent;

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
        private bool ShowAuthorView()
        {
            AuthorView fm = new AuthorView(_mainViewModel);
            if (fm.ShowDialog() == DialogResult.Cancel)
            {
                _mainViewModel.CourrnetAuthor = null;
                return false;
            }

            return true;
        }

        private void SearchAuthor()
        {
            List<Author> list;

            if (cbSearchOptions.SelectedIndex == 0)
                list = _mainViewModel.FiltrAuthor(FiltrAuthorMethod.NAME, tbSearchAuthor.Text);
            else
                list = _mainViewModel.FiltrAuthor(FiltrAuthorMethod.SURNAME, tbSearchAuthor.Text);

            _authorBinding.DataSource = list;
            dgvAuthors.Refresh();
        }

        private void ShowAllAuthor()
        {
            _authorBinding.DataSource = _mainViewModel.GetAllAuthors();
            dgvAuthors.Refresh();
        }
    }
}
