using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab05_analyzingUSBabyNames
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly List<BabyName> babies;
        private readonly StreamReader sr;
        private string path = @"babynames.txt";
        private List<int> decades;
        private string[,] topNames;

        public MainWindow()
        {
            InitializeComponent();
        
            babies = new List<BabyName>();
            sr = new StreamReader(path);
                  
        }

        private void lstDecadeTopNames_Loaded(object sender, RoutedEventArgs e)
        {
            while (!sr.EndOfStream)
            {
             
                babies.Add(new BabyName(sr.ReadLine()));
            }

            lstDecadeTopNames.ItemsSource = babies;
        }

        private void decadeName_Loaded(object sender, RoutedEventArgs e)
        {
            decades = new List<int>() {1900, 1910, 1920, 1930, 1940, 1950, 1960, 1970, 1980, 1990, 2000};
            decadeName.ItemsSource = decades;
             //topNames = new string[babies,];
        }


   
    }
}
