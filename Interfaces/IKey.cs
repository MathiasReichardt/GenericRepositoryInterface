namespace Interfaces
{
    public interface IKey<out TKey>
    {
        TKey Key { get; }
    }
}