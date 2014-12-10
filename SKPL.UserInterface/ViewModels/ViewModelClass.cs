using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows;

namespace SKPL.UserInterface.ViewModels
{
    public class ViewModelClass : INotifyPropertyChanged
    {
        public ViewModelClass()
        {
        }

        List<string> _source = new List<string> { "Lære", "Fag", "Elev", "Hold", "Hold Instance" };
        private string _SelectedItem;

        public List<string> Source { get { return _source; } }

        public string SelectedItem
        {
            get { return _SelectedItem; }
            set
            {
                _SelectedItem = value;
                RaisePropertyChanged(_SelectedItem);
            }
        }

        private bool _LGBV;

        public bool LGBV
        {
            get { return _LGBV; }
            set
            {
                _LGBV = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string selectedItemchange)
        {
            if (PropertyChanged != null)
            {
                string i = selectedItemchange.ToString();
                PropertyChanged(this, new PropertyChangedEventArgs(selectedItemchange));
                switch (i)
                {
                    case "Lære":
                        LGBV = true;
                        break;
                    case "Fag":
                        break;
                    case "Elev":
                        break;
                    case "Hold":
                        break;
                    case "Hold Instance":
                        break;
                }
            }
        }
    }

    class BoolToVisibleOrHidden : IValueConverter
    {
        public BoolToVisibleOrHidden()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool bValue = (bool) value;
            if (bValue)
                return Visibility.Visible;
            else
                return Visibility.Hidden;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Visibility visibility = (Visibility)value;

            if (visibility == Visibility.Visible)
                return true;
            else
                return false;
        }
    }
}
