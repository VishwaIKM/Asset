using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AssetManagementVishwa.View
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login_v : Window
    {
        private static log4net.ILog Log = log4net.LogManager.GetLogger(typeof(Login_v));
        public Login_v()
        {
            InitializeComponent();
            Log.Debug("TEST");
        }
    }
}
