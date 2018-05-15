using Autofac;
using DiAutofac;
using MySQL.Repositories;

namespace Library.ViewModel.Commands
{
    class SaveBookCommand : ICommand
    {
        private readonly MainViewModel _mainViewModel;

        public SaveBookCommand(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }

        public void Execute(object sender)
        {
            DiContainer.Container.Resolve<BookRepository>().Save(_mainViewModel.CourrnetBook);
        }
    }
}
