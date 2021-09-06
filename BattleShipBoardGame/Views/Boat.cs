using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace BattleShipBoardGame.Views
{
    public class Boat : UserControl
    {


        public Point Point
        {
            get { return (Point)GetValue(PointProperty); }
            set { SetValue(PointProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Point.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PointProperty =
            DependencyProperty.Register("Point", typeof(Point), typeof(Boat), new PropertyMetadata(null));


        public int Size
        {
            get { return (int)GetValue(SizeProperty); }
            set { SetValue(SizeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Size.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SizeProperty =
            DependencyProperty.Register("Size", typeof(int), typeof(Boat), new PropertyMetadata(1,
                new PropertyChangedCallback(OnSizeSet)));

        private static void OnSizeSet(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var boat = d as Boat;
            boat.Width = (int)e.NewValue * 50;
        }

        protected void UserControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragDrop.DoDragDrop(this, new DataObject(DataFormats.Serializable, this), DragDropEffects.Move);
            }
        }
    }
}
