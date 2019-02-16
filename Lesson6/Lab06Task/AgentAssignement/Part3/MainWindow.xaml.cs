using System.Windows;
using I4GUI;

namespace Part3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {
            if (NameListBox.SelectedIndex > 0)
            {
                NameListBox.SelectedIndex = --NameListBox.SelectedIndex;
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (NameListBox.SelectedIndex < NameListBox.Items.Count - 1)
            {
                NameListBox.SelectedIndex = ++NameListBox.SelectedIndex;
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var viewmodel = DataContext as MainWindowViewModel;
            if (viewmodel != null)
            {
                viewmodel.AddAnAgent();
            }
            NameListBox.SelectedIndex = NameListBox.Items.Count + 1;
        }
    }
}
