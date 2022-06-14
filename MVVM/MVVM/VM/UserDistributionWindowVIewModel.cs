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
        private CommandTemplate _openWindow;
        public CommandTemplate CreatePosterWindow
        {
            get
            {
                if (_openWindow == null)
                    _openWindow = new CommandTemplate(AddWindow);
                return _openWindow;
            }
        }

        public void AddWindow(object obj)
        {
            

            PosterWindow window = new PosterWindow();
            PosterWindowViewModel posterWindowViewModel = new PosterWindowViewModel();

            window.DataContext = posterWindowViewModel;
            window.Show();
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    
    }
}
