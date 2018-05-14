using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using DiAutofac;
using MySQL.Repositories;

namespace Library.ViewModel.Commands
{
    class SaveReaderCommand : ICommand
    {
        private readonly MainViewModel _mainViewModel;

        public SaveReaderCommand(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }

        public void Execute(object sender)
        {
            DiContainer.Container.Resolve<ReaderRepository>().Save(_mainViewModel.CourrnetReader);
        }
    }
}
