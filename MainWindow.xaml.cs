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
            Context.CourseSet.ToList();
            dgCourse.ItemsSource = Context.CourseSet.Local.ToObservableCollection();

            AttendantsTab.DataContext = new Attendant();
            Context.AttendantSet.ToList();
            dgAttendants.ItemsSource = Context.AttendantSet.Local.ToObservableCollection();
            
        }

        private void AddCourse(object sender, RoutedEventArgs e)
        {
            if (!Context.CourseSet.Where(x => x.Name == Name).Any())
            {
                Context.CourseSet.Add(CoursesTab.DataContext as Course);
                Context.SaveChanges();
            } else
            {
                throw new Exception("already exists");
            }         
        }

        private void AddAttendant(object sender, RoutedEventArgs e)
        {
            if (!Context.AttendantSet.Where(x => x.Name == Name).Any())
            {
                Context.AttendantSet.Add(AttendantsTab.DataContext as Attendant);
                Context.SaveChanges();
            }
            else
            {
                throw new Exception("already exists");
            }     
        }
    }
}
