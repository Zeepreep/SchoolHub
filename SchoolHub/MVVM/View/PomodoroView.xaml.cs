using System.Windows.Controls;
using SchoolHub.MVVM.ViewModel;

namespace SchoolHub.MVVM.View
{
    public partial class PomodoroView : UserControl
    {
        public PomodoroView()
        {
            InitializeComponent();
            var viewModel = DataContext as PomodoroViewModel;
        }
    }
}