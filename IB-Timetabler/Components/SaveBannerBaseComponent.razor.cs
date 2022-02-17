using System;
using IB_Timetabler.Models;
using IB_Timetabler.Services;
using Microsoft.AspNetCore.Components;

namespace IB_Timetabler.Components {

    public class SaveBannerBaseComponent : ComponentBase, IDisposable {

        [Inject] private SaveBannerService SaveBannerService { get; set; }

        protected string Heading { get; set; }
        protected string Message { get; set; }
        protected bool IsVisible { get; set; }
        protected string BackgroundCssClass { get; set; }
        protected string IconCssClass { get; set; }

        protected override void OnInitialized() {
            SaveBannerService.OnShow += ShowBanner;
            SaveBannerService.OnHide += HideBanner;
        }

        private void ShowBanner(string message, SaveBannerType type) {
            BuildBannerSettings(message, type);
            IsVisible = true;
            base.InvokeAsync(StateHasChanged);
        }

        private void HideBanner() {
            IsVisible = false;
            base.InvokeAsync(StateHasChanged);
        }

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

        public void Dispose() {
            SaveBannerService.OnShow -= ShowBanner;
        }
    }
}