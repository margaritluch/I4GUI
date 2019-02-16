using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace I4GUI
{
   public class Agent
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
         get
         {
            return _id;
         }
         set
         {
            _id = value;
         }
      }

      public string CodeName
      {
         get
         {
            return _codeName;
         }
         set
         {
            _codeName = value;
         }
      }

      public string Speciality
      {
         get
         {
            return _speciality;
         }
         set
         {
            _speciality = value;
         }
      }

      public string Assignment
      {
         get
         {
            return _assignment;
         }
         set
         {
            _assignment = value;
         }
      }
   }
}
