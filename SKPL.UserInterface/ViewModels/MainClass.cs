﻿using Microsoft.Practices.Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SKPL.UserInterface.Views;

namespace SKPL.UserInterface.ViewModels
{
    public class MainClass
    {
        public ICommand AddClickCommand
        {
            get { return new DelegateCommand<object>(AddFuncToCall); }
        }

        private void AddFuncToCall(object context)
        {
            var add = new AddData();
            add.Show();
        }

        public ICommand EditClickCommand
        {
            get { return new DelegateCommand<object>(EditFuncToCall); }
        }

        private void EditFuncToCall(object context)
        {
            var edit = new EditData();
            edit.Show();
        }

        public ICommand DeleteClickCommand
        {
            get { return new DelegateCommand<object>(DeleteFuncToCall); }
        }

        private void DeleteFuncToCall(object context)
        {
            var delete = new DeleteData();
            delete.Show();
        }

    }
}
