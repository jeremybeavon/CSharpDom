namespace CSharpDom.TestTarget.Interfaces
{
    public interface InterfaceWithGenericParameterGenericParameterConstraint<TKey, TValue>
        where TKey : TValue
    {
    }
}
