using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Interfaces;

namespace WpfApp1.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private IView view;

        public IView View
        {
            get
            {
                return view;
            }
            set
            {
                if (value == view)
                    return;

                view = value;
                view.DataContext = this;

                OnPropertyChanged("View");
            }
        }

        #region INotify

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
