using System;
using System.Timers;
using IB_Timetabler.Models;

namespace IB_Timetabler.Services {
    
    /// Inherits from IDisposable and is responsible for interacting with the SaveBannerComponent 
    public class SaveBannerService : IDisposable {

        /// Specifies an Action to take place when OnShow is invoked 
        public event Action<string, SaveBannerType> OnShow;
        /// Specifies an Action to take place when OnHide is invoked 
        public event Action OnHide;
        /// The Timer object used to determine when to dispose of the SaveBannerComponent 
        private Timer Countdown;

        /// The method publically called to display the SaveBannerComponent with the given message and type 
        public void ShowBanner(string message, SaveBannerType type) {
            OnShow?.Invoke(message, type);
            StartCountdown();
        }

        /// Starts the Countdown (resets it if it was already activated)  
        private void StartCountdown() {
            SetCountdown();
            if (Countdown.Enabled) {
                Countdown.Stop();
            }
            Countdown.Start();
        }

        /// Sets the Countdown behavior to hide the banner after the Countdown finishes 
        private void SetCountdown() {
            if (Countdown is not null) return;
            Countdown = new Timer(3000);
            Countdown.Elapsed += HideBanner;
            Countdown.AutoReset = false;
        }

        /// HidesInvokes the OnHide Action 
        private void HideBanner(object source, ElapsedEventArgs args) {
            OnHide?.Invoke();
        }

        /// Frees Countdown from memory 
        public void Dispose() {
            Countdown?.Dispose();
        }
    }
}