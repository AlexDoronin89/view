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
    internal class MovieWindowViewModel:INotifyPropertyChanged
    {

        private CommandTemplate _openWindow;
        public CommandTemplate CreateTicketWindow
        {
            get
            {
                if (_openWindow == null)
                    _openWindow = new CommandTemplate(AddTicketWindow);
                return _openWindow;
            }
        }

        public void AddTicketWindow(object obj)
        {


            TicketWindow window = new TicketWindow();
            TicketWindowViewModel ticketWindowViewModel = new TicketWindowViewModel();

            window.DataContext = ticketWindowViewModel;
            window.Show();
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    
    }
}
