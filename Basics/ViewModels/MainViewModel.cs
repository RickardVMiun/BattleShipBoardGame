using Basics.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

namespace Basics.ViewModels
{
    public class MainViewModel : BaseViewModel
    {

        //   public BaseViewModel CurrentViewModel { get; set; } = new ShowWizardViewModel();

        private BaseViewModel currentViewModel;

        public BaseViewModel CurrentViewModel
        {
            get { return currentViewModel; }
            set 
            { 
                currentViewModel = value;
                NotifyPropertyChanged();
            }
        }


        public ICommand ChangeViewCommand { get; }

        public MainViewModel()
        {
            ChangeViewCommand = new ChangeViewCommand(this);
        }

    }
}
