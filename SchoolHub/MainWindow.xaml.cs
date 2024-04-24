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

namespace SchoolHub
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainWindowGrid.MouseUp += new MouseButtonEventHandler(mainWindow_MouseUp);
            this.StateChanged += MainWindow_StateChanged;
        }

        private void MainWindow_StateChanged(object sender, EventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.MaxHeight = SystemParameters.WorkArea.Height;
            }
            else
            {
                this.MaxHeight = Double.PositiveInfinity;
            }
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                if (this.ResizeMode == ResizeMode.CanResize || this.ResizeMode == ResizeMode.CanResizeWithGrip)
                {
                    var mousePosition = e.GetPosition(this);
                    if (mousePosition.X <= this.ActualWidth && mousePosition.X >= this.ActualWidth - 5)
                    {
                        // Resize right
                        this.Width = mousePosition.X;
                    }

                    if (mousePosition.Y <= this.ActualHeight && mousePosition.Y >= this.ActualHeight - 5)
                    {
                        // Resize bottom
                        this.Height = mousePosition.Y;
                    }
                }
            }
        }

        private void mainWindow_MouseUp(object sender, MouseButtonEventArgs e)
        {
        }

        private void mainWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
        }

        private void TopButton_OnClick(object sender, RoutedEventArgs e)
        {
        }
    }
}