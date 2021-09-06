using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BattleShipBoardGame.Views
{
    /// <summary>
    /// Interaction logic for Carrier.xaml
    /// </summary>
    public partial class Carrier : Boat
    {
        public Carrier()
        {
            InitializeComponent();
            Size = 3;
        }
    }
}
