using Bibliosharp.Database;
using Microsoft.EntityFrameworkCore;

namespace Bibliosharp;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        //dbconection
        builder.Services.AddDbContext<DbBibliosharp>(options=> 
        options.UseMySql(
            builder.Configuration.GetConnectionString("BibliosharpDb"),
        ServerVersion.Parse("8.0.20-mysql")
        ));

        // Add services to the container.
        builder.Services.AddRazorPages();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapRazorPages();

        app.Run();
    }
}
