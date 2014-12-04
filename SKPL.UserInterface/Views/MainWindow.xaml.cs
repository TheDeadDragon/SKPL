using System.Windows;

namespace SKPL.UserInterface.Views
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
