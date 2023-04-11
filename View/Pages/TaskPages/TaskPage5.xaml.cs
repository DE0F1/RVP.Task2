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
    /// Логика взаимодействия для TaskPage5.xaml
    /// </summary>
    public partial class TaskPage5 : Page
    {
        public TaskPage5()
        {
            InitializeComponent();
        }

        private void BtnTask5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(TbA.Text);
                double b = Convert.ToDouble(TbB.Text);

                MessageBox.Show($"G = {(a % 2 == 1) && (b % 2 == 1)}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                TbA.Text = string.Empty;
                TbB.Text = string.Empty;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
