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
    internal class AdminDistributionViewModel: INotifyPropertyChanged
    {


        private CommandTemplate _openAddMovieWindow;
        private CommandTemplate _openAddSenseWindow;
        private CommandTemplate _openCreateActorWindow;

        public CommandTemplate CreateAddMovieWindow
        {
            get
            {
                if (_openAddMovieWindow == null)
                    _openAddMovieWindow = new CommandTemplate(AddMovieWindow);
                return _openAddMovieWindow;
            }
        }
        public CommandTemplate CreateAddSenseWindow
        {
            get
            {
                if (_openAddSenseWindow == null)
                    _openAddSenseWindow = new CommandTemplate(AddSenseWindow);
                return _openAddSenseWindow;
            }
        }
        public CommandTemplate CreateActorWindow
        {
            get
            {
                if (_openCreateActorWindow == null)
                    _openCreateActorWindow = new CommandTemplate(AddActorWindow);
                return _openCreateActorWindow;
            }
        }


        public void AddMovieWindow(object obj)
        {


            AddMovieWindow window = new AddMovieWindow();
            AddMovieWindowViewModel addMovieWindowViewModel = new AddMovieWindowViewModel();

            window.DataContext = addMovieWindowViewModel;
            window.Show();
        }

        public void AddSenseWindow(object obj)
        {


            AddSenseWindow window = new AddSenseWindow();
            AddSenseWindowViewModel addSenseWindowViewModel = new AddSenseWindowViewModel();

            window.DataContext = addSenseWindowViewModel;
            window.Show();
        }
        public void AddActorWindow(object obj)
        {


            CreateActorWindow window = new CreateActorWindow();
            AddActorWindowViewModel addActorWindowViewModel = new AddActorWindowViewModel();

            window.DataContext = addActorWindowViewModel;
            window.Show();
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    
    }
}
