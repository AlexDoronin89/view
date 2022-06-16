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
    internal class PosterWindowViewModel: INotifyPropertyChanged
    {
        private CommandTemplate _openWindow;
        public CommandTemplate CreateMovieWindow
        {
            get
            {
                if (_openWindow == null)
                    _openWindow = new CommandTemplate(AddMovieWindow);
                return _openWindow;
            }
        }

        public void AddMovieWindow(object obj)
        {


            MovieWindow window = new MovieWindow();
            MovieWindowViewModel movieWindowViewModel = new MovieWindowViewModel();

            window.DataContext = movieWindowViewModel;
            window.Show();
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    
    }
}
