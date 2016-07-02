namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint
    {
        public static class Class
        {
            public abstract class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
