using System;
using System.Windows.Input;
using System.Windows.Threading;
using SchoolHub.Core;

namespace SchoolHub.MVVM.ViewModel
{
    public class PomodoroViewModel : BaseViewModel
    {
        private DispatcherTimer timer;
        private TimeSpan timeLeft;
        private int startMinutes;
        private int shortBreakMinutes;
        private int longBreakMinutes;
        private int breakCount;
        private bool isBreakTime;
        private string timerState;

        public ICommand StartCommand { get; private set; }
        public ICommand StopCommand { get; private set; }
        public ICommand ResetCommand { get; private set; }

        public string TimerState
        {
            get { return timerState; }
            set
            {
                timerState = value;
                OnPropertyChanged();
            }
        }

        public int StartMinutes
        {
            get { return startMinutes; }
            set
            {
                startMinutes = value;
                OnPropertyChanged();
                if (!timer.IsEnabled)
                {
                    TimeLeft = TimeSpan.FromMinutes(StartMinutes);
                }
            }
        }

        public int ShortBreakMinutes
        {
            get { return shortBreakMinutes; }
            set
            {
                shortBreakMinutes = value;
                OnPropertyChanged();
            }
        }

        public int LongBreakMinutes
        {
            get { return longBreakMinutes; }
            set
            {
                longBreakMinutes = value;
                OnPropertyChanged();
            }
        }

        public PomodoroViewModel()
        {
            timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            timer.Tick += Timer_Tick;

            StartCommand = new RelayCommand(StartTimer);
            StopCommand = new RelayCommand(StopTimer);
            ResetCommand = new RelayCommand(ResetTimer);

            TimerState = "Paused";
        }

        public TimeSpan TimeLeft
        {
            get { return timeLeft; }
            set
            {
                timeLeft = value;
                OnPropertyChanged();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (TimeLeft.TotalSeconds > 0)
            {
                TimeLeft = TimeLeft.Add(TimeSpan.FromSeconds(-1));
            }
            else
            {
                timer.Stop();
                // Switch between start time, short break, and long break
                if (isBreakTime)
                {
                    breakCount++;
                    if (breakCount % 4 == 0)
                    {
                        TimeLeft = TimeSpan.FromMinutes(LongBreakMinutes);
                        TimerState = "Long Break";
                    }
                    else
                    {
                        TimeLeft = TimeSpan.FromMinutes(StartMinutes);
                        TimerState = "Study Time";
                        isBreakTime = false;
                    }
                }
                else
                {
                    TimeLeft = TimeSpan.FromMinutes(ShortBreakMinutes);
                    TimerState = "Short Break";
                    isBreakTime = true;
                }

                StartTimer(null);
            }
        }

        private void StartTimer(object obj)
        {
            if (!timer.IsEnabled)
            {
                timer.Start();
                TimerState = isBreakTime ? (breakCount % 4 == 0 ? "Long Break" : "Short Break") : "Study Time";
            }
        }

        private void StopTimer(object obj)
        {
            timer.Stop();
            TimerState = "Paused";
        }

        private void ResetTimer(object obj)
        {
            timer.Stop();
            isBreakTime = false;
            breakCount = 0;
            TimeLeft = TimeSpan.FromMinutes(StartMinutes);
            TimerState = "Paused";
        }
    }
}