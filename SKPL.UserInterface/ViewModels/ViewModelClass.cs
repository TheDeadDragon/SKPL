using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;

namespace SKPL.UserInterface.ViewModels
{
    public class ViewModelClass : INotifyPropertyChanged
    {
        //On Buttom click sends you to AddBtnFunction Function
        public ICommand AddBtnCommand
        {
            get { return new DelegateCommand<object>(AddBtnFunction); }
        }
        public ViewModelClass()
        {

        }

        private string _SelectedItem; //Private string to throw around in class
        public string SelectedItem //The check on selected combobox item
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
        private string _LFN;
        public string LFN
        {
            get { return _LFN; }
        }

        public string AddSelItem; //String to handle which combobox value is selected

        //Function to save written data depending on which combobox item is chosen.
        private void AddBtnFunction(object context)
        {
            string i = AddSelItem; //Sets i to current value of AddSelItem
            i = i.Replace("System.Windows.Controls.ComboBoxItem:",""); //Changes i depending which combobox item that is selected
            i = i.Trim(); //Removes Whitespace
            
            //Functionality missing but should add data to database depending on which combobox item is selected and check if all boxes are filled
            //Check i for switch case
            switch (i)
            {
                case "Lære":

                    break;

                case  "Elev":
                    break;

                case  "Fag":
                    break;

                case "Hold":
                    break;

                case "Hold Instans":
                    break;
            }
        }
    }
}
