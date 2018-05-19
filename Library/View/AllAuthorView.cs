using System.Collections.Generic;
using System.Windows.Forms;
using Library.Services;
using Library.ViewModel;
using MySQL.Entities;

namespace Library.View
{
    public partial class AllAuthorView : UserControl
    {
        private readonly MainViewModel _mainViewModel;
        private readonly BindingSource _authorBinding;

        public AllAuthorView(MainViewModel mainViewModel)
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

        public void RefreshView()
        {
            ShowAllAuthor();
        }

        private void btnAddAuthor_Click(object sender, System.EventArgs e)
        {
            _mainViewModel.CourrnetAuthor = new Author();

            if (!ShowAuthorView())
                return;

            _mainViewModel.SaveAuthor.Execute(null);
            _authorBinding.Add(_mainViewModel.CourrnetAuthor);
        }

        private void btnEditAuthor_Click(object sender, System.EventArgs e)
        {
            if (!(_authorBinding.Current is Author courrent))
                return;

            _mainViewModel.CourrnetAuthor = courrent;

            if (!ShowAuthorView())
                return;

            _mainViewModel.SaveAuthor.Execute(null);
            dgvAuthors.Refresh();
        }

        private void btnRemoveAuthor_Click(object sender, System.EventArgs e)
        {
            if (!(_authorBinding.Current is Author courrent))
                return;

            _mainViewModel.CourrnetAuthor = courrent;
            _mainViewModel.RemoveAuthor.Execute(null);
            _authorBinding.RemoveCurrent();
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

        private void dgvAuthors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditAuthor_Click(null, null);
        }

        private void tbSearchAuthor_TextChanged(object sender, System.EventArgs e)
        {
            if (tbSearchAuthor.Text.Length > 0)
                SearchAuthor();
            else
                ShowAllAuthor();
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
