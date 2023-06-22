using Microsoft.EntityFrameworkCore;
using Hospital.DAL;
using Hospital.BL.ViewModels;

namespace mvcD4Lab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //environmwnt variable & user secrets
            var connection = builder.Configuration.GetConnectionString("conn");

            builder.Services.AddDbContext<HospitalContext>(options =>
                    options.UseSqlServer(connection));

            builder.Services.AddScoped<IDoctorsRepo, DoctorsRepo>();
            builder.Services.AddScoped<IIssueRepo, IssueRepo>();
            builder.Services.AddScoped<IPatientRepo, PatientRepo>();

            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

            builder.Services.AddScoped<IDoctorManager, DoctorManager>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }   

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}