using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipBoardGame.ViewModels
{
    public class GameViewModel : BaseViewModel
    {

        public PlayerViewModel P1 { get; set; } = new Human();
        public PlayerViewModel P2 { get; set; } = new Cpu();


        public GameViewModel()
        {
            
        }

    }
}
