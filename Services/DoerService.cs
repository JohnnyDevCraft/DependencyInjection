using System;
using DependencyInjection.Interfaces;

namespace DependencyInjection.Services
{
    public class DoerService : IDoerService
    {
        private readonly IPrintMedium pm;

        public DoerService(IPrintMedium pm)
        {
            this.pm = pm;
        }

        public string Ask(string request)
        {
            pm.Print($"{request}: ");
            return Console.ReadLine();
        }

        public void Clear()
        {
            Console.Clear();
        }

        public void Print(string value)
        {
            pm.Print(value);
        }

        public void Print(string formatValue, params string[] values)
        {
            pm.Print(string.Format(formatValue, values));
        }
    }
}