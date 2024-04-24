using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Input;
using SchoolHub.Core;
using Newtonsoft.Json;
using System.IO;

namespace SchoolHub.MVVM.ViewModel
{
    public class CalendarViewModel : BaseViewModel
    {
        private DateTime currentDate;

        private const string RemindersFilePath = "reminders.json";

        private bool _isReminderMenuVisible;

        public bool IsReminderMenuVisible
        {
            get { return _isReminderMenuVisible; }
            set
            {
                _isReminderMenuVisible = value;
                OnPropertyChanged();
            }
        }

        private Reminder _selectedReminder;
        public Reminder SelectedReminder
        {
            get { return _selectedReminder; }
            set
            {
                OnPropertyChanged();

                if (value != null)
                {
                    IsEditingReminder = true;
                    _selectedReminder = value;
                    ReminderText = _selectedReminder.ReminderText;
                }
                else
                {
                    IsEditingReminder = false;
                }
            }
        }

        public ICommand ToggleReminderMenuCommand { get; }
        public ICommand DayClickedCommand { get; }

        public string ReminderText { get; set; }
        public DateTime? ReminderDate { get; set; }
        public ICommand AddReminderCommand { get; }
        public ICommand RemoveReminderCommand { get; }
        public bool IsEditingReminder { get; set; }
        public ICommand EditReminderCommand { get; }
        public string SelectedDay { get; set; }


        public ObservableCollection<Reminder> Reminders { get; } = new ObservableCollection<Reminder>();


        public CalendarViewModel()
        {
            LoadReminders();

            currentDate = DateTime.Now;
            GenerateMonth();
            NextMonthCommand = new RelayCommand(_ => NextMonth());
            PreviousMonthCommand = new RelayCommand(_ => PreviousMonth());
            ToggleReminderMenuCommand = new RelayCommand(_ => ToggleReminderMenu());
            DayClickedCommand = new RelayCommand(day => DayClicked(day));
            AddReminderCommand = new RelayCommand(_ => AddReminder());
            RemoveReminderCommand = new RelayCommand(_ => RemoveReminder());
            EditReminderCommand = new RelayCommand(reminder => EditReminder(reminder as Reminder));
        }

        public string CurrentMonthYear => currentDate.ToString("MMMM yyyy");

        public ObservableCollection<DayViewModel> Days { get; } = new ObservableCollection<DayViewModel>();

        public ICommand NextMonthCommand { get; }
        public ICommand PreviousMonthCommand { get; }

        private void LoadReminders()
        {
            if (File.Exists(RemindersFilePath))
            {
                var json = File.ReadAllText(RemindersFilePath);
                var reminders = JsonConvert.DeserializeObject<ObservableCollection<Reminder>>(json);
                foreach (var reminder in reminders)
                {
                    Reminders.Add(reminder);
                }
            }
        }

        private void SaveReminders()
        {
            var json = JsonConvert.SerializeObject(Reminders);
            File.WriteAllText(RemindersFilePath, json);
        }

        public void GenerateMonth()
        {
            Days.Clear();
            var firstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
            int offset = (int)firstDayOfMonth.DayOfWeek;
            var daysInMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);

            for (int i = 0; i < offset; i++)
            {
                Days.Add(new DayViewModel { Day = "", IsToday = false });
            }

            for (int day = 1; day <= daysInMonth; day++)
            {
                var date = new DateTime(currentDate.Year, currentDate.Month, day);
                bool isToday = date.Date == DateTime.Now.Date;
                var reminders = new ObservableCollection<Reminder>(Reminders.Where(r => r.Date.Date == date.Date));
                var dayViewModel = new DayViewModel { Day = day.ToString(), IsToday = isToday };
                dayViewModel.Reminders = reminders;
                Days.Add(dayViewModel);
            }
        }

        public void NextMonth()
        {
            currentDate = currentDate.AddMonths(1);
            GenerateMonth();
            OnPropertyChanged(nameof(CurrentMonthYear));
        }

        public void PreviousMonth()
        {
            currentDate = currentDate.AddMonths(-1);
            GenerateMonth();
            OnPropertyChanged(nameof(CurrentMonthYear));
        }

        private void ToggleReminderMenu()
        {
            IsReminderMenuVisible = !IsReminderMenuVisible;
        }


        private void DayClicked(object day)
        {
            if (day == null || string.IsNullOrWhiteSpace(day.ToString()))
            {
                return;
            }

            SelectedDay = day as string;
            ReminderDate = new DateTime(currentDate.Year, currentDate.Month, int.Parse(SelectedDay));
            IsReminderMenuVisible = true;

            ReminderText = string.Empty;
            IsEditingReminder = false;
        }

        private void UpdateDayViewModel(DateTime date, Reminder reminder, bool isAdding)
        {
            var dayViewModel = Days.FirstOrDefault(d => d.Day == date.Day.ToString());
            if (dayViewModel != null)
            {
                if (isAdding)
                {
                    dayViewModel.Reminders.Add(reminder);
                }
                else
                {
                    dayViewModel.Reminders.Remove(reminder);
                }
            }
        }

        private void AddReminder()
        {
            if (!string.IsNullOrEmpty(ReminderText) && ReminderDate.HasValue)
            {
                var newReminder = new Reminder { ReminderText = ReminderText, Date = ReminderDate.Value };
                Reminders.Add(newReminder);

                UpdateDayViewModel(newReminder.Date, newReminder, true);

                ReminderText = string.Empty;
                ReminderDate = SelectedDay == null
                    ? (DateTime?)null
                    : new DateTime(currentDate.Year, currentDate.Month, int.Parse(SelectedDay));

                IsReminderMenuVisible = false;
                IsEditingReminder = false;

                SaveReminders();
            }
        }

        private void RemoveReminder()
        {
            if (SelectedReminder != null)
            {
                Reminders.Remove(SelectedReminder);

                UpdateDayViewModel(SelectedReminder.Date, SelectedReminder, false);

                SaveReminders();

                IsEditingReminder = false;
                IsReminderMenuVisible = false;
            }
        }

        private void EditReminder(Reminder reminder)
        {
            if (reminder != null)
            {
                SelectedReminder = reminder;
                IsEditingReminder = true;
                ReminderText = reminder.ReminderText;

                IsReminderMenuVisible = true;
            }
        }

        public ObservableCollection<Reminder> SortedAndFilteredReminders
        {
            get
            {
                return new ObservableCollection<Reminder>(Reminders
                    .Where(r => r.Date.Date >= DateTime.Now.Date)
                    .OrderBy(r => r.Date));
            }
        }
    }


    public class DayViewModel : INotifyPropertyChanged
    {
        public string Day { get; set; }
        public bool IsToday { get; set; }

        private ObservableCollection<Reminder> _reminders = new ObservableCollection<Reminder>();

        public ObservableCollection<Reminder> Reminders
        {
            get { return _reminders; }
            set
            {
                if (_reminders != value)
                {
                    _reminders = value;
                    OnPropertyChanged(nameof(Reminders));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}