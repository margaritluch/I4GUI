using System;
using System.IO;
using System.Linq;
using System.Windows;


namespace Part1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string path = @"babynames.txt";
  
        public MainWindow()
        {
            InitializeComponent();  
        }

        private void lstDecadeTopNames_Loaded(object sender, RoutedEventArgs e)
        {
            /* eventhandler that is reading the text file and showing the first 10 lines in the listbox
             later on add excepthion handler for in case text file is empty*/
            var lines = File.ReadAllLines(path).Take(10);
            lstDecadeTopNames.ItemsSource = lines;
        }
    }
}