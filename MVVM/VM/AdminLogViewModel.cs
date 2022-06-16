using Poster.Model.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.VM
{
    internal class AdminLogViewModel: INotifyPropertyChanged
    {
        //private string _adminLogin;
        //private string _adminPassword;
        private CommandTemplate _openAdminDistributionWindow;

        public CommandTemplate CreateAdminDistributionWindow
        {
            get
            {
                if (_openAdminDistributionWindow == null)
                    _openAdminDistributionWindow = new CommandTemplate(AddAdminDistributionWindow);
                return _openAdminDistributionWindow;
            }
        }

        public void AddAdminDistributionWindow(object obj)
        {


            AdminDistributionWindow window = new AdminDistributionWindow();
            AdminDistributionViewModel adminDistributionViewModel = new AdminDistributionViewModel();

            window.DataContext = adminDistributionViewModel;
            window.Show();
        }

        //public string AdminLogin
        //{
        //    get { return _adminLogin; }
        //    set
        //    {
        //        _adminLogin = value;
        //        OnPropertyChanged(nameof(AdminLogin));
        //    }
        //}

        //public string AdminPassword
        //{
        //    get { return _adminPassword; }
        //    set
        //    {
        //        _adminPassword = value;
        //        OnPropertyChanged(nameof(AdminPassword));
        //    }
        //}

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    
    }
}
