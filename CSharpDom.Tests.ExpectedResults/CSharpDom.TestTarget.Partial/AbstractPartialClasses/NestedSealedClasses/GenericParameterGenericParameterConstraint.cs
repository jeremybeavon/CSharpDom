namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
