namespace SchoolHub.MVVM.ViewModel
{
    public class ViewModelLocator
    {
        private static PomodoroViewModel pomodoroViewModel = new PomodoroViewModel();

        public PomodoroViewModel PomodoroViewModel
        {
            get { return pomodoroViewModel; }
        }
    }
}