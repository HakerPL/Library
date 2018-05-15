using Autofac;
using DiAutofac;
using MySQL.Repositories;

namespace Library.ViewModel.Commands
{
    class RemoveBookCommand : ICommand
    {
        private readonly MainViewModel _mainViewModel;

        public RemoveBookCommand(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }

        public void Execute(object sender)
        {
            DiContainer.Container.Resolve<BookRepository>().Delete(_mainViewModel.CourrnetBook);
        }
    }
}
