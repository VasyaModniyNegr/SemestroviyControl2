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

namespace SemestroviyControl
{
    /// <summary>
    /// Логика взаимодействия для TestPage.xaml
    /// </summary>
    public partial class TestPage : Page
    {
        public TestPage()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Radio Button was checked");
        }
        private void CheckButtonClick(object sender, RoutedEventArgs e)
        {
            bool checkShowAnswer = FirstAnswer.IsChecked == true ||
                SecondAnswer.IsChecked == true ||
                ThirdAnswer.IsChecked == true ||
                FourtAnswer.IsChecked == true;

            if (FourtAnswer.IsChecked == true)
            {
                MessageBox.Show("Вы выбрали правильный ответ");
            }
            else if (checkShowAnswer == false)
            {
                MessageBox.Show("Вы не выбрали вариант ответа");
            }
            else
            {
                MessageBox.Show("Вы выбрали неправильный ответ");
            }
        }
    }
}
