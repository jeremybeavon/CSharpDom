namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
