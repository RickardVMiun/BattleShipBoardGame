using BattleShipBoardGame.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Text;

namespace BattleShipBoardGame.ViewModels
{
    public class PlayerViewModel : BaseViewModel
    {
        private static readonly Random random = new Random();
        private readonly int battleFieldSize = 10;
        public ObservableCollection<Ship> Ships { get; set; }

        private void FillFleet()
        {
            Ships = new ObservableCollection<Ship>()
            {
                new Battleship(),
                new Submarine(),
                new Cruiser(),

            };
        }

        public PlayerViewModel()
        {
            FillFleet();
            PlaceShipsRandomly();
        }

        public void PlaceShipsRandomly()
        {
            foreach (var Ship in Ships)
            {
                Ship.Direction = GetRandomDirection();
            }
        }

        private Point GetRandomOceanPoint()
        {

        }

        private Direction GetRandomDirection()
        {
            int magicNumber = random.Next(2);
            return (Direction)magicNumber;
        }

    }
}
