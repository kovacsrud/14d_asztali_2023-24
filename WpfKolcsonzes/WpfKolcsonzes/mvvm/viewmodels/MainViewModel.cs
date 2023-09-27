using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfKolcsonzes.mvvm.views;

namespace WpfKolcsonzes.mvvm.viewmodels
{
    public class MainViewModel
    {
        public ICommand NevjegyCommand { get; set; } = new WinNevjegyCommand();
        public ICommand WinDataCommand { get; set; } = new DataWinCommand();

        class WinNevjegyCommand : ICommand
        {
            public event EventHandler? CanExecuteChanged;

            public bool CanExecute(object? parameter)
            {
                return true;
            }

            public void Execute(object? parameter)
            {
                WinNevjegy winNevjegy=new WinNevjegy();
                winNevjegy.Show();
            }
        }
        class DataWinCommand : ICommand
        {
            public event EventHandler? CanExecuteChanged;

            public bool CanExecute(object? parameter)
            {
                return true;
            }

            public void Execute(object? parameter)
            {
                WinData winData=new WinData();
                winData.ShowDialog();
            }
        }
    }
}
