using BattleShipBoardGame.ViewModels;
using BattleShipBoardGame.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace BattleShipBoardGame.Commands
{
    public class RemoveBoatCommand : ICommand
    {
        private GameViewModel gameViewModel;

        public RemoveBoatCommand(GameViewModel gameViewModel)
        {
            this.gameViewModel = gameViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            var boat = (Boat)parameter;
            gameViewModel.Harbour.Remove(boat);
        }
    }
}
