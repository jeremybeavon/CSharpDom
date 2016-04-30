namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint
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
