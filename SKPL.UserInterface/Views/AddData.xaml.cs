using System.Collections;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Windows;

namespace SKPL.UserInterface.Views
{
    /// <summary>
    /// Interaction logic for AddData.xaml
    /// </summary>
    public partial class AddData : Window
    {
        public AddData()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            int AddBoxvalue = AddBox.SelectedIndex;
            switch (AddBoxvalue)
            {
                case 0:
                    TeacherBox.Visibility = Visibility.Visible;
                    StudentBox.Visibility = Visibility.Hidden;
                    ClassBox.Visibility = Visibility.Hidden;
                    LectureBox.Visibility = Visibility.Hidden;
                    break;
                case 1:
                    TeacherBox.Visibility = Visibility.Hidden;
                    StudentBox.Visibility = Visibility.Hidden;
                    ClassBox.Visibility = Visibility.Hidden;
                    LectureBox.Visibility = Visibility.Visible;
                    break;
                case 2:
                    TeacherBox.Visibility = Visibility.Hidden;
                    StudentBox.Visibility = Visibility.Hidden;
                    ClassBox.Visibility = Visibility.Visible;
                    LectureBox.Visibility = Visibility.Hidden;
                    break;
                case 3:
                    TeacherBox.Visibility = Visibility.Hidden;
                    StudentBox.Visibility = Visibility.Visible;
                    ClassBox.Visibility = Visibility.Hidden;
                    LectureBox.Visibility = Visibility.Hidden;
                    break;
                case 4:
                    TeacherBox.Visibility = Visibility.Hidden;
                    StudentBox.Visibility = Visibility.Hidden;
                    ClassBox.Visibility = Visibility.Hidden;
                    LectureBox.Visibility = Visibility.Hidden;
                    break;
                default:
                    TeacherBox.Visibility = Visibility.Visible;
                    StudentBox.Visibility = Visibility.Hidden;
                    ClassBox.Visibility = Visibility.Hidden;
                    LectureBox.Visibility = Visibility.Hidden;
                    break;
            }
        }
    }
}
