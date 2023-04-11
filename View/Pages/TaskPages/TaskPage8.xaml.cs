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

namespace RVP.Task._2.View.Pages.TaskPages
{
    /// <summary>
    /// Логика взаимодействия для TaskPage8.xaml
    /// </summary>
    public partial class TaskPage8 : Page
    {
        public TaskPage8()
        {
            InitializeComponent();
        }

        private void BtnTask8_1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int x = 1, y = 2;
                MessageBox.Show($"rX ={(x >= 0) && (Math.Pow(y,2) != 4)}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnTask8_2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int x = 2, y = 1;
                MessageBox.Show($"rY ={(x * y < 0) && (y < x)}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
