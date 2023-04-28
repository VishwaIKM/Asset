using Architecturalpattern_mvvm;
using AssetManagementVishwa.View.Pages;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AssetManagementVishwa.ViewModel
{
    internal class Dashboard_vm : INotifyPropertyChanged
    {

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private RelayCommand edit_clickCommand;

        public ICommand Edit_clickCommand
        {
            get
            {
                if (edit_clickCommand == null)
                {
                    edit_clickCommand = new RelayCommand(Edit_click);
                }

                return edit_clickCommand;
            }
        }

        private void Edit_click()
        {
            UpdateEntry_p _edit_page = new UpdateEntry_p();
            
        }
        #endregion
    }
}
