using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;

namespace mPlant
{
    public class Property : Control,INotifyPropertyChanged
    {
        private Station propertyType = Station.Station_Null;        

        public  Station PropertyType
        {
            set { propertyType = value; OnPropertyChanged("PropertyType");}
            get { return propertyType; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }       

    }

   
}
