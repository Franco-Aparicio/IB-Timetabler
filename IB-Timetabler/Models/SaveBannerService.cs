using System;
using System.Timers;

namespace IB_Timetabler.Models {
    
    public class SaveBannerService : IDisposable {

        public event Action<string, SaveBannerType> OnShow;
        public event Action OnHide;
        private Timer Countdown;

        public void ShowBanner(string message, SaveBannerType type) {
            OnShow?.Invoke(message, type);
            StartCountdown();
        }

        private void StartCountdown() {
            SetCountdown();
            if (Countdown.Enabled) {
                Countdown.Stop();
            }
            Countdown.Start();
        }

        private void SetCountdown() {
            if (Countdown is not null) return;
            Countdown = new Timer(3000);
            Countdown.Elapsed += HideBanner;
            Countdown.AutoReset = false;
        }

        private void HideBanner(object source, ElapsedEventArgs args) {
            OnHide?.Invoke();
        }

        public void Dispose() {
            Countdown?.Dispose();
        }
    }
}