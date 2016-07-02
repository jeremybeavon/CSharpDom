namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class
        {
            public abstract class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
