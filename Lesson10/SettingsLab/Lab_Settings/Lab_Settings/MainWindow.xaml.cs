using System;
using System.Windows;

namespace Lab_Settings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /* this part of code makes sure that settings file with its default values
             are not being discarded after deploying a new version of the app*/
            if (Properties.Settings.Default.CallUpgrade)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.CallUpgrade = false;
            }
            /*settings from appplication are read only*/
            nameTextBox.Text += Properties.Settings.Default.PName;
            /* settings from user are both read only and writeable*/
            ageTextBox.Text += Properties.Settings.Default.PAge;
        }

        private void changeAgeButton_Click(object sender, RoutedEventArgs e)
        {
            /*when button is clicked, the textbox value gets changed from
             default value to user input value and the new value is being saved*/
            Properties.Settings.Default.PAge = Int32.Parse(ageTextBox.Text);
            
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            /* when reset button is clicked the textbox text area is being cleared
             and value is being reset to default value*/
            ageTextBox.Clear();
  
            Properties.Settings.Default.Reset();
            ageTextBox.Text += Properties.Settings.Default.PAge;
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            ageTextBox.Clear();

            Properties.Settings.Default.Reload();
            ageTextBox.Text += Properties.Settings.Default.PAge;


        }
    }
}
