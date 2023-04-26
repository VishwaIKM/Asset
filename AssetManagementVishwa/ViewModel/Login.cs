using Architecturalpattern_mvvm;
using AssetManagementVishwa.Database;
using AssetManagementVishwa.Model;
using AssetManagementVishwa.View;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace AssetManagementVishwa.ViewModel
{
    internal class Login //: INotifyPropertyChanged
    {
        //#region Members and Inst.


        //#endregion


        //#region Properties
        //public LoginModel Login
        //{
        //    get => _login;
        //    set { _login = value; }
        //}
        //public string UserID
        //{
        //    get => Login.Id;
        //    set
        //    {
        //        if (Login.Id != value)
        //        {
        //            Login.Id = value;
        //            RaisePropertyChanged("UserID");
        //        }
        //    }
        //}
        //public string Password
        //{
        //    get => Login.Password;
        //    set
        //    {
        //        if (Login.Password != value)
        //        {
        //            Login.Password = value;
        //            RaisePropertyChanged("Password");
        //        }
        //    }
        //}
        //public bool IsLoginButtonEnable
        //{
        //    get => _isloginvisibile;
        //    set
        //    {
        //        if (_isloginvisibile != value)
        //        {
        //            _isloginvisibile = value;
        //            RaisePropertyChanged("IsLoginButtonEnable");
        //        }
        //    }
        //}
        //public string StatusLevelText
        //{
        //    get => _statusLevelText;

        //}
        //#endregion


        //#region Methods

        //private void RaisePropertyChanged(string propertyName)
        //{
        //    PropertyChangedEventHandler handler = PropertyChanged;
        //    if (handler != null)
        //    {
        //        handler(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //}

        //#endregion

        //#region ICommand BUTTON Method 
        //void LoginCommandMethodExcute()
        //{
        //    IsLoginButtonEnable = false;
        //    string username = UserID;
        //    string password = Password;
        //    // MessageBox.Show(UserID + Password);
        //    using (var ctx = new MyContext())
        //    {
        //        try
        //        {
        //            var query = ctx.User_DBSet.Where(p => p.USR_PassWord == Password && p.USR_login_Id == UserID).FirstOrDefault();
        //            if (query != null)
        //            {
        //                LoadingView _loadingView = new LoadingView();
        //                _loadingView.Show();

        //                App.Current.MainWindow.Close();
        //                App.Current.MainWindow = _loadingView;

        //            }
        //            else
        //                MessageBox.Show("Incorrect User ID or Password");
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Not Able to Connect SQL Server Check the Configuration of DataBase. " + ex.ToString());
        //        }
        //    }
        //    IsLoginButtonEnable = true;
        //}
        //void ExitCommandMethodExcute()
        //{
        //    Application.Current.Shutdown();
        //}
        //bool CanThisMethodExecute() { return true; }

        //#endregion

        //#region ICommand
        //public ICommand LoginCommand { get { return new RelayCommand(LoginCommandMethodExcute, CanThisMethodExecute); } }
        //public ICommand ExitAppCommand { get { return new RelayCommand(ExitCommandMethodExcute, CanThisMethodExecute); } }

        //#endregion

        //#region INotifyPropertyChanged Members

        //public event PropertyChangedEventHandler PropertyChanged;

        //#endregion

    }
}
