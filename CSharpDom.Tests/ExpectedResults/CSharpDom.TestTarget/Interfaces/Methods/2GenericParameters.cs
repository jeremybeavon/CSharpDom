namespace CSharpDom.TestTarget.Interfaces.Methods
{
    public interface IInterfaceWithMethodWith2GenericParameters
    {
        Dictionary<TKey, TValue> Method<TKey, TValue>();
    }
}
