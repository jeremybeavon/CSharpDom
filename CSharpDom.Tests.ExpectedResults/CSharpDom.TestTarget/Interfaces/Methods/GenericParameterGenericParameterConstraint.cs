namespace CSharpDom.TestTarget.Interfaces.Methods
{
    public interface IInterfaceWithMethodWithGenericParameterGenericParameterConstraint
    {
        Dictionary<TKey, TValue> Method<TKey, TValue>()
            where TValue : TKey;
    }
}
