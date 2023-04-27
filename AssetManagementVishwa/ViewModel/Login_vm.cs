using Architecturalpattern_mvvm;
using AssetManagementVishwa.Database;
using AssetManagementVishwa.Model;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using System.Windows;

namespace AssetManagementVishwa.ViewModel
{
    internal class Login_vm : INotifyPropertyChanged
    {
        #region Members and Inst.
        LoginModel _login = new LoginModel();
        private bool _isloginvisibile = true;
        private string _statusLevelText = "*Server is Not Connected";
        #endregion


        #region Properties
        public LoginModel UserDetails
        {
            get => _login;
            set { _login = value; }
        }
        public string UserID
        {
            get => UserDetails.Id;
            set
            {
                if (UserDetails.Id != value)
                {
                    UserDetails.Id = value;
                    RaisePropertyChanged("UserID");
                }
            }
        }
        public string Password
        {
            get => UserDetails.Password;
            set
            {
                if (UserDetails.Password != value)
                {
                    UserDetails.Password = value;
                    RaisePropertyChanged("Password");
                }
            }
        }
        public bool IsLoginButtonEnable
        {
            get => _isloginvisibile;
            set
            {
                if (_isloginvisibile != value)
                {
                    _isloginvisibile = value;
                    RaisePropertyChanged("IsLoginButtonEnable");
                }
            }
        }
        public string StatusLevelText
        {
            get => _statusLevelText;

        }
        #endregion


        #region Methods

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region ICommand BUTTON Method 
        void LoginCommandMethodExcute()
        {
            IsLoginButtonEnable = false;
            using (var ctx = new MyContext())
            {
                try
                {
                    var query = ctx.UserManagement.Where(p => p.Password == Password && p.Id == UserID).FirstOrDefault();
                    if (query != null)
                    {
                        View.Loading_v _loadingView = new View.Loading_v();
                        _loadingView.Show();

                        App.Current.MainWindow.Close();
                        App.Current.MainWindow = _loadingView;

                    }
                    else
                        MessageBox.Show("Incorrect User ID or Password");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Not Able to Connect SQL Server. " + ex.ToString());
                    IsLoginButtonEnable = true;
                }
                IsLoginButtonEnable = true;
            }
            IsLoginButtonEnable = true;
        }
        void ExitCommandMethodExcute()
        {
            Application.Current.Shutdown();
        }
        bool CanThisMethodExecute() { return true; }

        #endregion

        #region ICommand
        public ICommand LoginCommand { get { return new RelayCommand(LoginCommandMethodExcute, CanThisMethodExecute); } }
        public ICommand ExitAppCommand { get { return new RelayCommand(ExitCommandMethodExcute, CanThisMethodExecute); } }

        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

    }
}
