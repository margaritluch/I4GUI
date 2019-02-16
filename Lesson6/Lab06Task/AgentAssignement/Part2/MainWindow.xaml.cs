using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using I4GUI;

namespace Part2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ObservableCollection<Agent> agents;
        public MainWindow()
        {
            InitializeComponent();
            agents = new ObservableCollection<Agent>();
            DataContext = agents;
            

        }

        private void NameListBox_Loaded(object sender, RoutedEventArgs e)
        {
            Agent agent = new Agent("123","Ola","student","ggg");
            Agent ag = new Agent("124", "Ho", "student", "ggg");
            agents.Add(agent);
            agents.Add(ag);
        }
    }
}
