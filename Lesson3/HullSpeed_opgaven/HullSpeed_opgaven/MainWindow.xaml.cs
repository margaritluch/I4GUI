using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


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

        private void Name_TextChanged(object sender, TextChangedEventArgs e)
        {
            s.Name += Name.Text;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.L) && Keyboard.IsKeyDown(Key.LeftCtrl))
            {
                this.FontSize--;
            }

            if (Keyboard.IsKeyDown(Key.S) && Keyboard.IsKeyDown(Key.LeftCtrl))
            {
                this.FontSize++;
            }
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
        
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                if (s.Name != null && !string.IsNullOrWhiteSpace(s.Name))
                {
                    MessageBox.Show("The name of the ship is" + " " + Name.Text);
                }

                else
                {
                    MessageBox.Show("The name of the ship is unknown");
                }
            }
        }
    }
}