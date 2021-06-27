namespace TddKatas.Stack
{
    public interface IStack<T>
    {
        IStack<T> Push(T value);
        IStack<T> Pop();
        T Peek();
        bool isEmpty { get; }
    }
}