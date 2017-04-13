namespace Decorator.Core
{
    public interface IDecorator
    {
        GetResponse Handle(GetRequest request);
    }
}