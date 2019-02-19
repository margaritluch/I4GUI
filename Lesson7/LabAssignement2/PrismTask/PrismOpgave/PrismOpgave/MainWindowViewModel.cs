using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;

namespace PrismOpgave
{
    class MainWindowViewModel : BindableBase
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

        public ObservableCollection<Agent> SomeAgents
        {
            get
            {
                return Agents;
            }
        }



        private Agent currentAgent = null;
        public Agent CurrentAgent
        {
            get { return currentAgent; }
            set
            {
                SetProperty(ref currentAgent, value);
                //if (currentPerson != value)
                //{
                //    currentPerson = value;
                //    NotifyPropertyChanged();
                //}
            }
        }

        int currentIndex = -1;
        public int CurrentIndex
        {
            get { return currentIndex; }
            set
            {
                SetProperty(ref currentIndex, value);
            }
        }

        ICommand _PreviusCommand;
        public ICommand PreviusCommand
        {
            get
            {
                return _PreviusCommand ??
                       (_PreviusCommand = new DelegateCommand(
                           PreviusCommandExecute, PreviusCommandCanExecute).ObservesProperty(() => CurrentIndex));
            }
        }

        private void PreviusCommandExecute()
        {
            if (CurrentIndex > 0)
                --CurrentIndex;
        }

        private bool PreviusCommandCanExecute()
        {
            if (CurrentIndex > 0)
                return true;
            else
                return false;
        }

        ICommand _nextCommand;
        public ICommand NextCommand => _nextCommand ?? (_nextCommand = new DelegateCommand(
                                           () => ++CurrentIndex,
                                           () => CurrentIndex < (Agents.Count - 1)).ObservesProperty(() => CurrentIndex));

        ICommand _newCommand;
        public ICommand NewCommand
        {
            get
            {
                return _newCommand ?? (_newCommand = new DelegateCommand(() =>
                {
                    Agents.Add(new Agent());
                    CurrentIndex = Agents.Count - 1;
                }));
            }
        }

        ICommand _addCommand;
        public ICommand AddCommand
        {
            get
            {
                return _newCommand ?? (_newCommand = new DelegateCommand(() =>
                {
                    Agents.Add(new Agent());
                    CurrentIndex = Agents.Count - 1;
                }));
            }
        }
    }
}

