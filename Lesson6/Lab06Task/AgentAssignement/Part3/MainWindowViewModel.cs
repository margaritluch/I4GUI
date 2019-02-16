using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using I4GUI;

namespace Part3
{
    public class MainWindowViewModel : INotifyPropertyChanged

    {
        ObservableCollection<Agent> Agents;

        public MainWindowViewModel()
        {
            Agents = new ObservableCollection<Agent>
            {
                new Agent("11", "Karina Mortensen", "antropologist", "task 1"),
                new Agent("12", "Martja Kosowa", "dentist", "task 2"),
                new Agent("13", "Andrej Putin", "president", "task 3"),
                new Agent("14", "Aleksey Sokolyev", "correspondent", "task 4"),
                new Agent("15", "Amanda Jerkins", "psychologist", "task 5"),
                new Agent("16", "Ashley Snowden", "manager", "task 6"),
                new Agent("14", "Maria Jensen", "student", "task 7")
            };

            CurrentAgent = Agents[0];
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        Agent _agent = null;

        public Agent CurrentAgent
        {
            get { return _agent; }

            set
            {
                if (_agent != value)
                {
                    _agent = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableCollection<Agent> agents
        {
            get { return Agents; }
        }
    }
}

