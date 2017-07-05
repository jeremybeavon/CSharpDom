namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
