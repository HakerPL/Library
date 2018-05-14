using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.ViewModel;
using MySQL.Entities;

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

        //private const int CP_NOCLOSE_BUTTON = 0x200;
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams myCp = base.CreateParams;
        //        myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
        //        return myCp;
        //    }
        //}
    }
}
