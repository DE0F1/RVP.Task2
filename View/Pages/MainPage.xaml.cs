using RVP.Task._2.Core;
using System.Windows;
using System.Windows.Controls;
using RVP.Task._2.View.Pages.TaskPages;


namespace RVP.Task._2.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new TaskPage1());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new TaskPage2());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new TaskPage3());

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new TaskPage4());

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new TaskPage5());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new TaskPage6());
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new TaskPage7());
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new TaskPage8());
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new TaskPage9());
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new TaskPage10());
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new TaskPage11());
        }
    }
}
