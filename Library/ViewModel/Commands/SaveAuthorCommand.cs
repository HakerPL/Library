using Autofac;
using DiAutofac;
using MySQL.Repositories;

namespace Library.ViewModel.Commands
{
    class SaveAuthorCommand : ICommand
    {
        private readonly MainViewModel _mainViewModel;

        public SaveAuthorCommand(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }

        public void Execute(object sender)
        {
            DiContainer.Container.Resolve<AuthorRepository>().Save(_mainViewModel.CourrnetAuthor);
        }
    }
}
