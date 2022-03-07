using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ElectronNET.API;
using ElectronNET.API.Entities;
using IB_Timetabler.Models;
using IB_Timetabler.Services;
using Microsoft.EntityFrameworkCore;

namespace IB_Timetabler {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        /// This method gets called by the runtime. Use this method to add services to the container.
        /// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) {
            // Register all services used in the application (including database context) 
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddDbContext<IBTimetablerContext>(option => {
                option.UseSqlite(Configuration.GetConnectionString("Default"));
            });
            services.AddScoped<LessonService>();
            services.AddScoped<TeacherService>();
            services.AddScoped<RoomService>();
            services.AddScoped<BlockService>();
            services.AddScoped<LessonIdblockIdService>();
            services.AddScoped<RoomIdlessonIdService>();
            services.AddScoped<PeriodService>();
            services.AddScoped<SaveService>();
            services.AddScoped<SavedLessonService>();
            services.AddScoped<SavedLessonIdperiodIdService>();
            services.AddScoped<SaveBannerService>();
            services.AddScoped<SchedulerService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
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
            // Apply the database migration (to create and initialize a database with seed data) if no database found 
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>()?.CreateScope()) {
                var context = serviceScope?.ServiceProvider.GetRequiredService<IBTimetablerContext>();
                context?.Database.Migrate();
            }
            // Create the electron window 
            if (HybridSupport.IsElectronActive) {
                CreateWindow();
            }
        }

        private async void CreateWindow() {
            var windowOptions = new BrowserWindowOptions {
                AutoHideMenuBar = true,
                Title = "IB-Timetabler",
                Width = 1570,
                Height = 1000,
                MinWidth = 500,
                MinHeight = 300
            };
            // Creates window with the specified options above 
            var window = await Electron.WindowManager.CreateWindowAsync(windowOptions);

            var menu = new MenuItem[] {
                new MenuItem {
                    Label = "File",
                    Type = MenuType.submenu,
                    Submenu = new MenuItem[] {
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
                            Label = "Dev Tools",
                            Role = MenuRole.toggledevtools,
                            Accelerator = "CmdOrCtrl+I"
                        }
                    }
                }
            };
            // Sets the application menu to the custom menu defined above 
            Electron.Menu.SetApplicationMenu(menu);
            
            await window.WebContents.Session.ClearCacheAsync();
            window.OnReadyToShow += () => window.Show();
            window.OnClosed += () => {
                Electron.App.Quit();
            };
        }
    }
}