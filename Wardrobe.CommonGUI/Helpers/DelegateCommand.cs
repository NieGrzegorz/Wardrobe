﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Wardrobe.CommonGUI
{

    /// <summary>
    /// Class implementing DelagateCommand 
    /// It enables Binding of a Command
    /// </summary>
    public class DelegateCommand : ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;


        public DelegateCommand(Action execute, Func<bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
            => _canExecute == null || _canExecute();

        public void Execute(object parameter)
            => _execute(); 

        public void RaiseCanExecuteChanged()
        {

        }

    }
}
