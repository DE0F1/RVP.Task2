using System;
using System.Windows;
using System.Windows.Controls;
using RVP.Task._2.View.Pages.TaskPages;
using RVP.Task._2.Core;


namespace RVP.Task._2.View.Pages.TaskPages
{
    /// <summary>
    /// Логика взаимодействия для TaskPage10.xaml
    /// </summary>
    public partial class TaskPage10 : Page
    {
        public TaskPage10()
        {
            InitializeComponent();
        }

        private void BtnTask10_1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int A = 1, B = 0, C = 1;
                MessageBox.Show($"rA ={A | ~(A & B) | C}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnTask10_2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int A = 1, B = 0, C = 1;
                MessageBox.Show($"rB ={~A | C & ~(B | C)}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnTask10_3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int A = 1, B = 0, C = 1;
                MessageBox.Show($"rC ={(A | B & ~C) | A}", "Системное сообщение",
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
