
namespace Spread.Betting.Services.Interfaces
{
    public interface ILogger
    {
        void Debug(string message);
        void Warn(string message);
        void Info(string message);
        void Error(string message);
        void Fatal(string message);
    }
}
