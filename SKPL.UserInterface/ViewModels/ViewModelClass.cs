using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.ComponentModel;
namespace SKPL.UserInterface.ViewModels
{
    public class ViewModelClass : INotifyPropertyChanged
    {
        public ViewModelClass()
        {
        }

        private List<string> _source = new List<string> {"Lære", "Fag", "Elev", "Hold", "Hold Instance"};
        private string _selectedItem = null;

        public List<string> Source
        {
            get { return _source; }
        }

        public string SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                //string Content = (string) value.Content;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /*private void RaisePropertyChanged(string SelectedItemchange)
        {
        }*/
    }
}
