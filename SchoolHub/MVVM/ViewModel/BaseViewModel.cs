using System.ComponentModel;

namespace SchoolHub.MVVM.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _className;

        public string ClassName
        {
            get { return _className; }
            set
            {
                _className = value;
                OnPropertyChanged(nameof(ClassName));
            }
        }

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class Class1ViewModel : BaseViewModel
    {
        public Class1ViewModel()
        {
            ClassName = "Class 1";
        }
    }

    public class Class2ViewModel : BaseViewModel
    {
        public Class2ViewModel()
        {
            ClassName = "Class 2";
        }
    }
}