namespace CSharpDom.TestTarget.Partial.PartialInterfaces.Methods
{
    public interface IInterfaceWithMethodWithGenericParameterGenericParameterConstraint
    {
        Dictionary<TKey, TValue> Method<TKey, TValue>()
            where TValue : TKey;
    }
}
