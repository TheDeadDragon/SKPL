using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SKPL.UserInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Opret_OnClick(object sender, RoutedEventArgs e)
        {
            var add = new AddData();
            add.Show();
        }

        private void Redigere_Click(object sender, RoutedEventArgs e)
        {
            var edit = new EditData();
            edit.Show();
        }

        private void Slet_Click(object sender, RoutedEventArgs e)
        {
            var delete = new DeleteData();
            delete.Show();
        }
    }
}
