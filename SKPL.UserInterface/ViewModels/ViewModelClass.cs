using System.ComponentModel;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;

namespace SKPL.UserInterface.ViewModels
{
    public class ViewModelClass : INotifyPropertyChanged
    {
        public ICommand AddBtnCommand
        {
            get { return new DelegateCommand<object>(AddBtnFunction); }
        }
        public ViewModelClass()
        {
        }
        private string _SelectedItem;
        public string SelectedItem
        {
            get { return _SelectedItem; }
            set
            {
                _SelectedItem = value;
                RaisePropertyChanged(_SelectedItem);
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string selectedItemchange)
        {
            if (PropertyChanged != null)
            {
                AddSelItem = selectedItemchange;
                PropertyChanged(this, new PropertyChangedEventArgs(selectedItemchange));
            }
        }
        public string AddSelItem;
        private void AddBtnFunction(object context)
        {
            string i = AddSelItem;
            i = i.Replace("System.Windows.Controls.ComboBoxItem:","");
            i = i.Trim();
            switch (i)
            {
                case "Lære":
                    string name = 
                    break;
            }
        }
    }
}
