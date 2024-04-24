using System.DirectoryServices.ActiveDirectory;
using System.Windows;
using System.Windows.Input;
using SchoolHub.Core;   

namespace SchoolHub.MVVM.ViewModel;

public class MainViewModel : ObservableObject
{
    public RelayCommand HomeViewCommand { get; set; }
    public RelayCommand CalendarViewCommand { get; set; }
    public RelayCommand AssignmentsViewCommand { get; set; }
    public RelayCommand PomodoroViewCommand { get; set; }

    public HomeViewModel HomeVM { get; set; }

    public CalendarViewModel CalendarVm { get; set; }

    public AssignmentsViewModel AssignmentsVM { get; set; }

    private object _currentView;

    public ICommand DragWindowCommand { get; set; }
    public ICommand MinimizeWindowCommand { get; set; }
    public ICommand MaximizeRestoreWindowCommand { get; set; }
    public ICommand CloseWindowCommand { get; set; }
    
    public PomodoroViewModel PomodoroVM { get; set; }

    public object CurrentView
    {
        get { return _currentView; }
        set
        {
            _currentView = value;
            OnPropertyChanged();
        }
    }

    public MainViewModel()
    {
        PomodoroVM = new PomodoroViewModel();
        HomeVM = new HomeViewModel(this);
        CalendarVm = new CalendarViewModel();
        AssignmentsVM = new AssignmentsViewModel();
        CurrentView = HomeVM;

        HomeViewCommand = new RelayCommand(o => { CurrentView = HomeVM; });

        CalendarViewCommand = new RelayCommand(o => { CurrentView = CalendarVm; });

        AssignmentsViewCommand = new RelayCommand(o => { CurrentView = AssignmentsVM; });
        
        PomodoroViewCommand = new RelayCommand(o => { CurrentView = PomodoroVM; });

        DragWindowCommand = new RelayCommand(DragWindow);
        MinimizeWindowCommand = new RelayCommand(MinimizeWindow);
        MaximizeRestoreWindowCommand = new RelayCommand(MaximizeRestoreWindow);
        CloseWindowCommand = new RelayCommand(CloseWindow);
    }

    private void DragWindow(object window)
    {
        if (window is System.Windows.Window w)
        {
            w.DragMove();
        }
    }

    private void MinimizeWindow(object window)
    {
        if (window is System.Windows.Window w)
        {
            w.WindowState = WindowState.Minimized;
        }
    }

    private void MaximizeRestoreWindow(object window)
    {
        if (window is System.Windows.Window w)
        {
            w.WindowState = w.WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
        }
    }

    private void CloseWindow(object window)
    {
        if (window is System.Windows.Window w)
        {
            w.Close();
        }
    }
}