namespace DependencyInjection.Interfaces
{
    public interface IDoerService
    {
        void Print(string value);
        void Print(string formatValue, params string[] values);

        void Clear();
        string Ask(string request);
    }
}