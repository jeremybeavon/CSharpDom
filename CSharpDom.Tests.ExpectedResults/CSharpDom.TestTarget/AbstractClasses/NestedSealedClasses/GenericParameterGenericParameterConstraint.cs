namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
