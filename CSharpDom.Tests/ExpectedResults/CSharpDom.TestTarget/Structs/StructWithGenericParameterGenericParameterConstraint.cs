namespace CSharpDom.TestTarget.Structs
{
    public struct StructWithGenericParameterGenericParameterConstraint<TKey, TValue>
        where TKey : TValue
    {
    }
}
