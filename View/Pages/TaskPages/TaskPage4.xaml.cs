﻿using System;
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
    /// Логика взаимодействия для TaskPage4.xaml
    /// </summary>
    public partial class TaskPage4 : Page
    {
        public TaskPage4()
        {
            InitializeComponent();
        }

        private void BtnTask4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(TbA.Text);

                MessageBox.Show($"A = {(a % 2 == 0) || (a % 3 == 0)}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                TbA.Text = string.Empty;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
