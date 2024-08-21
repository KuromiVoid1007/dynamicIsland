using Microsoft.Win32;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace dynamicIsland
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            ShowInTaskbar = false;
        }


        private void Button_Click_calc(object sender, RoutedEventArgs e)
        {
            Process.Start("calc.exe");
        }
        private void Button_Click_server(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"C:\Users\coolv\AppData\Local\Programs\Termius\Termius.exe", UseShellExecute = true });
        }

        private void Button_Click_VsCode(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe", UseShellExecute = true });
        }

        private void Button_Click_kiilRoskomnadzor(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"D:\goodbyedpi-0.2.2\x86_64\goodbyedpi.exe", UseShellExecute = true });
        }

        private void Button_Click_tray(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void TaskbarIcon_TrayLeftMouseDown(object sender, RoutedEventArgs e)
        {
            this.Show();
        }

        private void clic_exit(object sender, EventArgs e)
        {
            System.Windows.Application.Current.Shutdown();  
        }
    }
}