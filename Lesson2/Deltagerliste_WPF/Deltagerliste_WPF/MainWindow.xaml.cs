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
            MyList.ItemsSource = ReadCSV();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        //public IEnumerable<DeltagerListe> ReadCSV(string fileName)
        public IEnumerable<DeltagerListe> ReadCSV()
        {
            
            string path = @"C:\Users\Bruger\Desktop\GUI\02 deltagerliste.csv";
       
            //string[] lines = File.ReadAllLines(System.IO.Path.ChangeExtension(fileName, ".csv"));
            string[] lines = File.ReadAllLines(path);
   
            return lines.Select(line =>
            {
                string[] data = line.Split(';');
                
                // We return a person with the data in order.
                //ToDO this line needs to e formatted, errorprone
                return new DeltagerListe(Int32.Parse(data[0]),data[1], Convert.ToChar(data[2]), Convert.ToChar(data[3]),data[4], data[5], data[6]);
            });
 
        }
    }
}
