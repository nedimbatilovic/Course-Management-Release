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

namespace Course_Management_Release
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CoursesTab.DataContext = new Course();
            dgCourse.ItemsSource = CourseSet;
            CourseSet.Add(new Course { Name = "Deutsch", DurationStart = 1, DurationEnd = 30 });
        }

        private void AddCourse(object sender, RoutedEventArgs e)
        {
            CourseManagementDbContext.CourseSet.Add(CoursesTab.DataContext as Course);
        }
    }
}
