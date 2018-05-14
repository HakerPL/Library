using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ViewModel.Commands
{
    class RemoveAuthorCommand : ICommand
    {
        private MainViewModel _mainViewModel;

        public RemoveAuthorCommand(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }

        public void Execute(object sender)
        {
            throw new NotImplementedException();
        }
    }
}
