using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace WindowsAnd_DialogsTask
{
    public class AgentViewModel: BindableBase
    {
        public AgentViewModel(string title, Agent agent)
        {
            Title = title;
            CurrentAgent = agent;
        }

        #region Properties
        string title;

        public string Title
        {
            get { return title; }
            set
            {
                SetProperty(ref title, value);
            }
        }
        Agent currentAgent;

        public Agent CurrentAgent
        {
            get { return currentAgent; }
            set
            {
                SetProperty(ref currentAgent, value);
            }
        }

        //bool isValid;

        public bool IsValid
        {
            get
            {
                bool isValid = true;
                if (string.IsNullOrWhiteSpace(CurrentAgent.Id))
                    isValid = false;
                if (string.IsNullOrWhiteSpace(CurrentAgent.CodeName))
                    isValid = false;
                return isValid;
            }
            //set
            //{
            //    SetProperty(ref isValid, value);
            //}
        }

        ObservableCollection<string> specialities;
        public ObservableCollection<string> Specialities
        {
            get { return specialities; }
            set
            {
                SetProperty(ref specialities, value);
            }
        }
        #endregion

        #region Commands

        #endregion
    }
}
}
