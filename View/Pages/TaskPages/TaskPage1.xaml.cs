using System;
using System.Windows;
using System.Windows.Controls;

namespace RVP.Task._2.View.Pages.TaskPages
{
    public partial class TaskPage1 : Page
    {
        public TaskPage1()
        {
            InitializeComponent();
        }

        private void BtnTask1_1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int A = 1, B = 0, C = 1;
                MessageBox.Show($"rA ={(A | ~A & B) | C}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void BtnTask1_2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int A = 1, B = 0, C = 1;
                MessageBox.Show($"rB ={~A | A & (B | C)}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnTask1_3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int A = 1, B = 0, C = 1;
                MessageBox.Show($"rC ={(A | B & ~C) & C}", "Системное сообщение",
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