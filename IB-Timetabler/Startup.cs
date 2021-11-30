using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using IB_Timetabler.Data;
using ElectronNET.API;
using ElectronNET.API.Entities;
using IB_Timetabler.Models;
using Microsoft.EntityFrameworkCore;
using Syncfusion.Blazor;

namespace IB_Timetabler {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();
            services.AddDbContext<IBTimetablerContext>(option => {
                option.UseSqlite(Configuration.GetConnectionString("Default"));
            });
            services.AddScoped<LessonService>();
            services.AddScoped<TeacherService>();
            services.AddSyncfusionBlazor();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTQxNTk4QDMxMzkyZTMzMmUzMElhRGc2cVNhQVpGTVMxR0NvdzRCanZpSGVhTU5TS1NvS01yMi90UFlPYjQ9");
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }
            else {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints => {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
            
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope()) {
                var context = serviceScope.ServiceProvider.GetRequiredService<IBTimetablerContext>();
                context.Database.Migrate();
            }

            if (HybridSupport.IsElectronActive) {
                CreateWindow();
            }
        }

        private async void CreateWindow() {
            var windowOptions = new BrowserWindowOptions {
                AutoHideMenuBar = true,
                Title = "IB-Timetabler",
                Width = 1500,
                Height = 1000,
                MinWidth = 500,
                MinHeight = 300
                // Icon = $"{System.IO.Directory.GetCurrentDirectory()}/Assets/favicon_32x32.png"
            };
            var window = await Electron.WindowManager.CreateWindowAsync(windowOptions);

            var menu = new MenuItem[] {
                new MenuItem {
                    Label = "File",
                    Type = MenuType.submenu,
                    Submenu = new MenuItem[] {
                        new MenuItem {
                            Label = "New",
                            Click = () => Electron.Dialog.ShowMessageBoxAsync("New menu clicked")
                        },
                        new MenuItem {
                            Type = MenuType.separator
                        },
                        new MenuItem {
                            Label = "Close",
                            Role = MenuRole.close
                        }
                    }
                },
                new MenuItem {
                    Label = "Edit",
                    Type = MenuType.submenu,
                    Submenu = new MenuItem[] {
                        new MenuItem {
                            Label = "Force Reload",
                            Role = MenuRole.forcereload,
                            Accelerator = "CmdOrCtrl+R"
                        },
                        new MenuItem {
                            Label = "Test",
                            Click = () => Electron.Dialog.ShowMessageBoxAsync("Test menu clicked"),
                            Accelerator = "CmdOrCtrl+T"
                        },
                        new MenuItem {
                            Label = "Dev Tools",
                            Role = MenuRole.toggledevtools,
                            Accelerator = "CmdOrCtrl+I"
                        }
                    }
                }
            };
            Electron.Menu.SetApplicationMenu(menu);
            
            await window.WebContents.Session.ClearCacheAsync();
            window.OnReadyToShow += () => window.Show();
            window.OnClosed += () => {
                Electron.App.Quit();
            };
        }
    }
}