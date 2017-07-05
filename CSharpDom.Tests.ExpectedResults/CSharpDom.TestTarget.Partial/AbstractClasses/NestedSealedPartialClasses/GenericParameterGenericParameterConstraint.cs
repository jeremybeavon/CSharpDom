namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
