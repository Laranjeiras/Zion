using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Zion.Common.Mvvm
{
    public class AsyncCommandHandler : ICommand
    {
        private readonly Func<Task> _execute;
        private readonly Func<object, bool> _canExecute;

        public event EventHandler CanExecuteChanged;

        public AsyncCommandHandler(Func<Task> execute) : this(execute, null)
        {

        }

        public AsyncCommandHandler(Func<Task> execute, Func<object, bool> canExecute)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute ?? (x => true);
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? false : _canExecute(parameter);
        }

        public async void Execute(object parameter)
        {
            await _execute();
        }

        public Task ExecuteAsync(object parameter)
        {
            return _execute();
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
