using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Agent_DataView
{
    public class Agent:INotifyPropertyChanged
    {
        private string _id;
        private string _codeName;
        private string _speciality;
        private string _assignment;

        public Agent()
        {
        }

        public Agent(string aId, string aName, string aSpeciality, string aAssignment)
        {
            _id = aId;
            _codeName = aName;
            _speciality = aSpeciality;
            _assignment = aAssignment;
        }

        public string Id
        {

            get { return this._id; }
            set
            {
                if (this._id == value) { return; }
                this._id = value;
                Notify();
            }
        }

        public string CodeName
        {
            get { return this._codeName; }
            set
            {
                if (this._codeName == value) { return; }
                this._codeName = value;
                Notify();
            }
        }

        public string Speciality
        {
            get { return this._speciality; }
            set
            {
                if (this._speciality == value) { return; }
                this._speciality = value;
                Notify();
            }
        }

        public string Assignment
        {
            get { return this._assignment; }
            set
            {
                if (this._assignment == value) { return; }
                this._assignment = value;
                Notify();
            }
        }


        // INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;

        protected void Notify([CallerMemberName]string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}

