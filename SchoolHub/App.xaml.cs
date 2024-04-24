using System.Configuration;
using System.Data;
using System.Windows;

namespace SchoolHub;

public partial class App : Application
{
    private void Application_Startup(object sender, StartupEventArgs e)
    {
        MainWindow wnd = new MainWindow();
        wnd.Title = "The Main Window";
        
        if(e.Args.Length == 1)
            MessageBox.Show("Now opening file: \n\n" + e.Args[0]);
        wnd.Show();
    }
    
}