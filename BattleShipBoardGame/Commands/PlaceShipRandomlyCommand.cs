using BattleShipBoardGame.ViewModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Input;

namespace BattleShipBoardGame.Commands
{
    class PlaceShipRandomlyCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private GameViewModel gameViewModel;
public PlaceShipRandomlyCommand(GameViewModel gameViewModel)
        {
            this.gameViewModel = gameViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //gameViewModel.P1.PlaceShipsRandomly();
            //gameViewModel.P1.ExposeAllShips();
            var result = gameViewModel.P1.UnderAttack(new Point(1, 1));
            result = gameViewModel.P1.UnderAttack(new Point(1, 2));
            result = gameViewModel.P1.UnderAttack(new Point(1, 3));
            result = gameViewModel.P1.UnderAttack(new Point(1, 4));
            result = gameViewModel.P1.UnderAttack(new Point(1, 5));
        }
    }
}
