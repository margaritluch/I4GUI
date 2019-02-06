using System;
using System.Windows;
using System.Windows.Controls;


namespace HullSpeed_opgaven
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Sailboat s;

        public MainWindow()
        {
            InitializeComponent();
            s = new Sailboat();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            Result.Text += s.Hullspeed().ToString();
        }

        private void Length_TextChanged(object sender, TextChangedEventArgs e)
        {
            s.Length = Double.Parse(Length.Text);
        }
    }
}