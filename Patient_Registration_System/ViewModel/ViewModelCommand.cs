using System;
using System.Windows.Controls;
using System.Windows.Input;

namespace Patient_Registration_System.ViewModel
{
    public class ViewModelCommand : ICommand
    {
        // private readonly Action<object> _executeAction;
        private readonly Action<TextBox> _executeAction;
        private readonly Predicate<object> _canExecuteAction;

        public ViewModelCommand(Action<object> executeAction)
        {
            _executeAction = executeAction;
            
        }

        //public ViewModelCommand(Action<object, TextBox> executeShowUserSetingViewCommand)
        //{
        //    ExecuteShowUserSetingViewCommand = executeShowUserSetingViewCommand;
        //}

        //public ViewModelCommand(Action<object> executeAction, Predicate<object> canExecuteAction)
        //{
        //    _executeAction = executeAction;
        //    _canExecuteAction = canExecuteAction;
        //}
        public ViewModelCommand(Action<TextBox> executeAction, Predicate<object> canExecuteAction)
        {
            _executeAction = executeAction;
            _canExecuteAction = canExecuteAction;
        }

      //  public Action<object, TextBox> ExecuteShowUserSetingViewCommand { get; }

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value;}
        }

        public bool CanExecute(object? parameter)
        {
            return _canExecuteAction == null ? true: _canExecuteAction(parameter);
        }

        public void Execute(object? parameter)
        {
            // _executeAction(parameter);
            _executeAction(parameter as TextBox);
        }
    }
}