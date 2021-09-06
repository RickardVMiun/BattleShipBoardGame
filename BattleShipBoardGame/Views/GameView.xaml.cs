using BattleShipBoardGame.ViewModels;
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
    /// Interaction logic for GameView.xaml
    /// </summary>
    public partial class GameView : UserControl
    {
        public GameView()
        {
            InitializeComponent();
        }

        private void ocean_DragOver(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);
            if (data is Boat)
            {
                var boat = (Boat)data;
                Point dropPosition = e.GetPosition(ocean);
                var calculatedPoint = GetCalculatedPoint(dropPosition);
                Canvas.SetLeft(boat, calculatedPoint.X);
                Canvas.SetTop(boat, calculatedPoint.Y);
                if (!ocean.Children.Contains(boat))
                {
                    harbour.Children.Remove(boat);
                    ocean.Children.Add(boat);
                }
            }
        }

        private Point GetCalculatedPoint(Point dropPoint)
        {
            int cellSize = 50;
            var x = dropPoint.X;
            var y = dropPoint.Y;

            var col = Math.Floor(y / cellSize);
            var row = Math.Floor(x / cellSize);

            y = col * cellSize;
            x = row * cellSize;
            return new Point(x, y);
        }

        private void ocean_Drop(object sender, DragEventArgs e)
        {
            if (e.Source is Boat boat)
            {
                var left = Canvas.GetLeft(boat);
                var top = Canvas.GetTop(boat);
                var point = ConvertToPoint(left, top);
                var viewModel = (GameViewModel)DataContext;
                viewModel.DropBoatCommand.Execute(null);
            }
        }

        private Point ConvertToPoint(double left, double top)
        {
            var x = (left + 50) / 50;
            var y = (top + 50) / 50;
            return new Point(x, y);
        }
    }
}
