using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;

namespace mPlant
{
    public class Infor : Control,INotifyPropertyChanged
    {
        private string inforString = null;        

        public string InforString
        {
            set { inforString = value; OnPropertyChanged("InforString");}
            get { return inforString; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }    
        
        



    }

   
}
