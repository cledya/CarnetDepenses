using System;
using System.Collections.Generic;
using System.Text;

namespace CarnetDepenses.ViewModels;

public class RelayCommandP : System.Windows.Input.ICommand
{
    private readonly Action<object> _execute;
    public RelayCommandP(Action<object> execute) => _execute = execute;
    public bool CanExecute(object parameter) => true;
    public void Execute(object p) => _execute(p);
    public event EventHandler CanExecuteChanged;
}


