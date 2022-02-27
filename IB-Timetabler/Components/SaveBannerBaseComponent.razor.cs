using System;
using IB_Timetabler.Models;
using IB_Timetabler.Services;
using Microsoft.AspNetCore.Components;

namespace IB_Timetabler.Components {

    /// The code class behind the SaveBannerComponent that inherits from ComponentBase and IDisposable
    public class SaveBannerBaseComponent : ComponentBase, IDisposable {

        [Inject] private SaveBannerService SaveBannerService { get; set; }

        protected string Heading { get; set; }
        protected string Message { get; set; }
        /// Used to determine whether to show or hide the SaveBannerComponent
        protected bool IsVisible { get; set; }
        /// Used to customize the banner style
        protected string BackgroundCssClass { get; set; }
        /// Used to customize the banner icon
        protected string IconCssClass { get; set; }

        /// Sets the OnShow and OnHide actions to custom functions 
        protected override void OnInitialized() {
            SaveBannerService.OnShow += ShowBanner;
            SaveBannerService.OnHide += HideBanner;
        }

        /// Modifies banner to fit desired type, marks as visible, then prompts refresh 
        private void ShowBanner(string message, SaveBannerType type) {
            BuildBannerSettings(message, type);
            IsVisible = true;
            base.InvokeAsync(StateHasChanged);
        }

        /// Marks banner as not visible and prompts refresh
        private void HideBanner() {
            IsVisible = false;
            base.InvokeAsync(StateHasChanged);
        }

        /// Customizes banner settings to desired type 
        private void BuildBannerSettings(string message, SaveBannerType type) {
            switch (type) {
                case SaveBannerType.Info: {
                    BackgroundCssClass = "bg-info";
                    IconCssClass = "info";
                    Heading = "Info";
                    break;
                }
                case SaveBannerType.Success: {
                    BackgroundCssClass = "bg-success";
                    IconCssClass = "check";
                    Heading = "Success";
                    break;
                }
                case SaveBannerType.Warning: {
                    BackgroundCssClass = "bg-warning";
                    IconCssClass = "exclamation";
                    Heading = "Warning";
                    break;
                }
                case SaveBannerType.Error: {
                    BackgroundCssClass = "bg-danger";
                    IconCssClass = "times";
                    Heading = "Error";
                    break;
                }
            }
            Message = message;
        }

        /// Unsets the ShowBanner OnShow Action
        public void Dispose() {
            SaveBannerService.OnShow -= ShowBanner;
        }
    }
}