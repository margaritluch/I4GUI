using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace Deltagerliste_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //we call the method that is reading the csv file and showing data in listviwe
            MyList.ItemsSource = ReadCSV();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        public IEnumerable<DeltagerListe> ReadCSV()
        {
            //reading csv file from the path and putting data into array
            string path = @"C:\Users\Bruger\Desktop\GUI\02 deltagerliste.csv";
            string[] lines = File.ReadAllLines(path);

            //splitting lines into cells and putting into new array, using LINQ
            return lines.Select(line =>
            {
                string[] data = line.Split(';');

                // We return a person with the data in order.
                //ToDO change it in a way to be able to see danish æ, ø, å
                return new DeltagerListe(data[0], data[1], data[2],
                    data[3], data[4], data[5], data[6]);
            });
        }
    }
}