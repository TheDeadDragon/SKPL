using Microsoft.Practices.Prism.Commands;
using System.Windows.Input;
using SKPL.UserInterface.Views;

namespace SKPL.UserInterface.ViewModels
{
    public class MainClass
    {
        //On Buttom click sends you to AddWindow Function
        public ICommand AddClickCommand
        {
            get { return new DelegateCommand<object>(AddWindow); }
        }

        //Shows AddData window
        private static void AddWindow(object context)
        {
            var add = new AddData();
            add.Show();
        }

        //On Buttom click sends you to EditWindow Function
        public ICommand EditClickCommand
        {
            get { return new DelegateCommand<object>(EditWindow); }
        }

        //Shows EditData window
        private static void EditWindow(object context)
        {
            var edit = new EditData();
            edit.Show();
        }

        //On Buttom click sends you to DeleteFucnctoCall Function
        public ICommand DeleteClickCommand
        {
            get { return new DelegateCommand<object>(DeleteWindow); }
        }

        //Shows DeleteData window
        private static void DeleteWindow(object context)
        {
            var delete = new DeleteData();
            delete.Show();
        }

        //Onclick sends you to UpdateCourseBox Function
        public ICommand CalenderClickCommand
        {
            get { return new DelegateCommand<object>(UpdateCourseBox); }
        }

        //Function to send text to our messagebox/Showing the courses and teachers on the day chosen
        private static void UpdateCourseBox(object context)
        {
            //Text to textbox
            
            /////////////////
        }
    }
}
