namespace CSharpDom.TestTarget
{
    public interface IInterfaceWithMethodWith2GenericParameters
    {
        Dictionary<TKey, TValue> Method<TKey, TValue>();
    }
}
