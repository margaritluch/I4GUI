using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace WindowsAnd_DialogsTask
{
    /// <summary>
    /// Interaction logic for AgentView.xaml
    /// </summary>
    public partial class AgentView : Window
    {
        public AgentView()
        {
            InitializeComponent();
        }
        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as AgentViewModel;
            if (vm.IsValid)
                DialogResult = true;
            else
                MessageBox.Show("Enter values for Id, code name and speciality", "Missing data");
        }
    }
}
