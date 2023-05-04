using Lab6.Visitors;

namespace Lab6.Components

{
    public interface IVisitable
    {
        string Accept(IVisitor visitor);
    }
}
