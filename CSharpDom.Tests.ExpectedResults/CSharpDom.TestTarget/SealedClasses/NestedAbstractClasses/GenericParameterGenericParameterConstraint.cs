namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
