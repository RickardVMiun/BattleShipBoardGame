using BattleShipBoardGame.Commands;
using BattleShipBoardGame.Data;
using BattleShipBoardGame.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace BattleShipBoardGame.ViewModels
{
    public class GameViewModel : BaseViewModel
    {

        public PlayerViewModel P1 { get; set; } = new Human();
        public PlayerViewModel P2 { get; set; } = new Cpu();

        public ObservableCollection<Boat> Harbour { get; set; }

        public ICommand PlaceShipRandomlyCommand { get; }
        public ICommand OceanClickedCommand { get; }
        public ICommand DropBoatCommand { get; }

        public ICommand RemoveBoatCommand { get;}

        public GameViewModel()
        {
            PlaceShipRandomlyCommand = new PlaceShipRandomlyCommand(this);
            OceanClickedCommand = new OceanClickedCommand(this);
            DropBoatCommand = new DropBoatCommand(this);
            RemoveBoatCommand = new RemoveBoatCommand(this);
            FillHarbour();
        }

        private void FillHarbour()
        {
            Harbour = new ObservableCollection<Boat>
            {
                new Submarine(),
                new Carrier()

            };
        }
    }
}
