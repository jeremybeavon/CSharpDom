namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint
    {
        public static class Class
        {
            public static class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
