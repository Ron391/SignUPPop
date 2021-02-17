using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace SignUPPop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txt_Email_MouseEnter(object sender, MouseEventArgs e)
        {
            lbl_Email.Visibility = Visibility.Hidden;
        }

        private void txt_Password_MouseEnter(object sender, MouseEventArgs e)
        {
            lbl_Password.Visibility = Visibility.Hidden;
        }

        private void txt_ConfirmP_MouseEnter(object sender, MouseEventArgs e)
        {
            lbl_CPassword.Visibility = Visibility.Hidden;
        }

        private void txt_Email_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool isEmail = Regex.IsMatch(txt_Email.Text.Trim(), @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (isEmail)
            {
                img_yesEmail.Visibility = Visibility.Visible;
                img_noEmail.Visibility = Visibility.Hidden;
            }
            else
            {
                img_noEmail.Visibility = Visibility.Visible;
                img_yesEmail.Visibility = Visibility.Hidden;
            }
        }

        private void txt_Password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (txt_Password.Password.Length <= 5)
            {
                grd_unreliable.Visibility = Visibility.Visible;
                grd_average.Visibility = Visibility.Hidden;
                grd_complicated.Visibility = Visibility.Hidden;
            }
            else if (txt_Password.Password.Length > 5 && txt_Password.Password.Length <= 10)
            {
                grd_unreliable.Visibility = Visibility.Hidden;
                grd_average.Visibility = Visibility.Visible;
                grd_complicated.Visibility = Visibility.Hidden;
            }
            else if (txt_Password.Password.Length > 10)
            {
                grd_unreliable.Visibility = Visibility.Hidden;
                grd_average.Visibility = Visibility.Hidden;
                grd_complicated.Visibility = Visibility.Visible;
            }
        }

        private void txt_ConfirmP_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (txt_Password.Password.Trim() == txt_ConfirmP.Password.Trim())
            {
                img_yesPass.Visibility = Visibility.Visible;
                img_nopass.Visibility = Visibility.Hidden;
            }
            else
            {
                img_yesPass.Visibility = Visibility.Hidden;
                img_nopass.Visibility = Visibility.Visible;
            }
        }
    }
}
