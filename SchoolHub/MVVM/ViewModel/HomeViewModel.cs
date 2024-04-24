using System.Windows.Input;
using SchoolHub.Core;

namespace SchoolHub.MVVM.ViewModel
{
    public class HomeViewModel : ObservableObject
    {
        private readonly MainViewModel _mainViewModel;

        public ICommand AssignmentViewCommand { get; private set; }
        public ICommand HomeViewCommand { get; private set; }
        public ICommand CalendarViewCommand { get; private set; }
        public ICommand PomodoroViewCommand { get; private set; }
        
        public CalendarViewModel CalendarVM { get; private set; }

        public HomeViewModel(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;

            AssignmentViewCommand = new RelayCommand(NavigateToAssignments);
            HomeViewCommand = new RelayCommand(NavigateToHome);
            CalendarViewCommand = new RelayCommand(NavigateToCalendar);
            PomodoroViewCommand = new RelayCommand(NavigateToTools);
            
            CalendarVM = new CalendarViewModel();
        }

        private void NavigateToAssignments(object obj)
        {
            _mainViewModel.CurrentView = _mainViewModel.AssignmentsVM;
        }

        private void NavigateToHome(object obj)
        {
            _mainViewModel.CurrentView = _mainViewModel.HomeVM;
        }
        
        private void NavigateToTools(object obj)
        {
            _mainViewModel.CurrentView = _mainViewModel.PomodoroVM;
        }
        
        private void NavigateToCalendar(object obj)
        {
            _mainViewModel.CurrentView = _mainViewModel.CalendarVm;
        }
    }
}