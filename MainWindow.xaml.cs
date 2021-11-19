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
        public CourseManagementDbContext Context { get; set; } = new();
        public MainWindow()
        {
            InitializeComponent();
            Context.Database.EnsureCreated();

            CoursesTab.DataContext = new Course();
            dgCourse.ItemsSource = Context.CourseSet.Local.ToObservableCollection();
            Context.Add(new Course { Name = "Deutsch", DurationStart = DateTime.Parse("11/1/2021."), DurationEnd = DateTime.Parse("11/30/2021.") });
        }

        private void AddCourse(object sender, RoutedEventArgs e)
        {
            Context.CourseSet.Add(CoursesTab.DataContext as Course);
            Context.SaveChanges();
        }
    }
}
