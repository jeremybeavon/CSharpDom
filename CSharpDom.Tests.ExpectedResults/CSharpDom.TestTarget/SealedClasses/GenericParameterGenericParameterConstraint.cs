namespace CSharpDom.TestTarget.SealedClasses
{
    public sealed class SealedClassWithGenericParameterGenericParameterConstraint<TKey, TValue>
        where TKey : TValue
    {
    }
}
