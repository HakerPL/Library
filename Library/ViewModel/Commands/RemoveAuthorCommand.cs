using Autofac;
using DiAutofac;
using MySQL.Repositories;

namespace Library.ViewModel.Commands
{
    class RemoveAuthorCommand : ICommand
    {
        private readonly MainViewModel _mainViewModel;

        public RemoveAuthorCommand(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }

        public void Execute(object sender)
        {
            DiContainer.Container.Resolve<AuthorRepository>().Delete(_mainViewModel.CourrnetAuthor);
        }
    }
}
