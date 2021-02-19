namespace DependencyInjection.Models
{
    public class ConsoleAppOptions
    {
        public string AppName { get; set; }
        public bool SaveOutputHistory { get; set; }
        public bool RequireKey { get; set; }
        public string Key { get; set; }
    }
}