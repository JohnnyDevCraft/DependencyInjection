using System;
using System.Collections.Generic;

namespace DependencyInjection.Interfaces
{
    public interface IMenu
    {
        Dictionary<string, Action> MenuItems { get; set; }  
        IMenu PreviousMenu { get; set; }
    }
}