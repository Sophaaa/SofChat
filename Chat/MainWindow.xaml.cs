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
using Microsoft.Win32;

namespace Chat
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

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            UsernameTB.Visibility = Visibility.Hidden;
            string v = "Online";
            StatusLabel.Content = v;
        }

        private void ButtonImg_Click(object sender, RoutedEventArgs e)
        {
            //OpenFileDialog openFile = new OpenFileDialog();
            //if (openFile.ShowDialog() == true)
            //{
            //    Avatar.Source = new BitmapImage(new Uri(openFile.FileName));

            //}
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void ButtonMinimaze_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void ButtonMaximazed_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState != WindowState.Maximized)
            {
                this.WindowState = WindowState.Maximized;
                this.ResizeMode = ResizeMode.NoResize;
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            //if (tb_login.Text == "Username")
            //{
            //    tb_login.Text = string.Empty;
            //}
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            //if (tb_login.Text == string.Empty)
            //{
            //    tb_login.Text = "Username";
            //}


            //var authpc = ClassHelper.Appdata.Context.User.ToList().
            // Where(i => i.Login == tb_login.Text).FirstOrDefault();
            //if (authpc != null || authpc != null)

            //{
            //    Window1 mw = new Window1();
            //    mw.Show();
            //    this.Close();
            //}
            //else
            //{

            //    MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

            //    return;
            //}
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Login_btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
