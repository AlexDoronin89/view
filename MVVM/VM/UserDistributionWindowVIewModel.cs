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
    internal class UserDistributionWindowVIewModel:INotifyPropertyChanged
    {
        private CommandTemplate _openAdminWindow;
        private CommandTemplate _openPosterWindow;

        public CommandTemplate CreatePosterWindow
        {
            get
            {
                if (_openPosterWindow == null)
                    _openPosterWindow = new CommandTemplate(AddPosterWindow);
                return _openPosterWindow;
            }
        }
        public CommandTemplate CreateAdminWindow
        {
            get
            {
                if (_openAdminWindow == null)
                    _openAdminWindow = new CommandTemplate(AddAdminWindow);
                return _openAdminWindow;
            }
        }

        public void AddPosterWindow(object obj)
        {
            

            PosterWindow window = new PosterWindow();
            PosterWindowViewModel posterWindowViewModel = new PosterWindowViewModel();

            window.DataContext = posterWindowViewModel;
            window.Show();
        }
        public void AddAdminWindow(object obj)
        {


            AdminLog window = new AdminLog();
            AdminLogViewModel adminLogViewModel = new AdminLogViewModel();

            window.DataContext = adminLogViewModel;
            window.Show();
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    
    }
}
