namespace Spread.Betting.Providers.Interfaces
{
    public interface IFormatProvider<T>
    {
        T Format(string payload);
    }
}
