using System.Collections.ObjectModel;
using System.Windows.Input;
using SchoolHub.Core;

namespace SchoolHub.MVVM.ViewModel;

public class AssignmentsViewModel : BaseViewModel
{
    private BaseViewModel _currentViewModel;

    public BaseViewModel CurrentViewModel
    {
        get { return _currentViewModel; }
        set
        {
            _currentViewModel = value;
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }

    public ICommand ShowClassCommand { get; }

    public AssignmentsViewModel()
    {
        ShowClassCommand = new RelayCommand(param => ShowClass(param));
    }

    private void ShowClass(object param)
    {
        switch (param)
        {
            case "Class1":
                CurrentViewModel = new Class1ViewModel();
                break;
            case "Class2":
                CurrentViewModel = new Class2ViewModel();
                break;
        }
    }
}