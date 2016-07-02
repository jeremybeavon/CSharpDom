namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
