using System;
using DependencyInjection.Models;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection.Interfaces
{
    public interface IConsoleApp
    {
        IMenu CurrentMenu { get; set; }
        IMenu PreviousMenu { get; set; }

        ServiceProvider ServiceProvider {get; set;}

        void LoadMenu(IMenu menu);
        void GoBack(IMenu menu);
        void ReloadMenu();
        void Exit();
        void Configure(Action<ConsoleAppOptions> configuration);
        void UseStartup<T>() where T: Startup;
        void Run();
    }
}