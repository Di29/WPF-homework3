using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;


namespace ClickMe
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

           
        }

        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {
            int min = 0;
            int max = 800;
            Random random = new Random();
            int x = random.Next(min, max);
            int y = random.Next(min, max);

            Point point = new Point(x, y);

            clickme.PointToScreen(point);

            DoubleAnimation posAnim = new DoubleAnimation(x, TimeSpan.FromSeconds(1));

            clickme.BeginAnimation(MarginProperty, posAnim);
            clickme.Background = Brushes.AliceBlue;
        }
    }
}
