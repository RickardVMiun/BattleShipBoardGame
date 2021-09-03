using Basics.Data;
using Basics.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Basics.Commands
{
    public class ChangeViewCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private MainViewModel mainViewModel;

        public ChangeViewCommand(MainViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            GotoView view = (GotoView)parameter;

            switch (view)
            {
                case GotoView.Hogwarts:
                    mainViewModel.CurrentViewModel = new HogwartsViewModel();
                    break;
                case GotoView.ShowWizard:
                    mainViewModel.CurrentViewModel = new ShowWizardViewModel();
                    break;
                default:
                    break;
            }
        }
    }
}
