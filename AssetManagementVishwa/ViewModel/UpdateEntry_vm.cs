using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagementVishwa.ViewModel
{
    internal class UpdateEntry_vm : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
        private string _selectedItem;
        private ObservableCollection<string> _items = new ObservableCollection<string>(){
            "V",
            "Vi",
            "Vis",
            "Vish",
            "Vishw",
            "Vishwa",
        };
        public IEnumerable Items
        {
            get { return _items; }
        }

        public string SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }

        public string NewItem
        {
            set
            {
                if (SelectedItem != null)
                {
                    return;
                }
                if (!string.IsNullOrEmpty(value))
                {
                    _items.Add(value);
                    SelectedItem = value;
                }
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (!Equals(field, newValue))
            {
                field = newValue;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }

            return false;
        }
        private string sysUser;

        public string SysUser { get => sysUser; set => SetProperty(ref sysUser, value); }
    }
}
