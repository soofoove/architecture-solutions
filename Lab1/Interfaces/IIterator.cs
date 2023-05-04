namespace Lab1.Interfaces;

public interface IIterator<T>
{
    bool HasNext();
    T? Next();
}