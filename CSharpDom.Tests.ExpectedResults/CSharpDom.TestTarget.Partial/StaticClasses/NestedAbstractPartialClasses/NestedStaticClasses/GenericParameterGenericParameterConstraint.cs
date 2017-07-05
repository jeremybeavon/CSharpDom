namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedAbstractPartialClassWithNestedStaticPartialClassWithGenericParameterGenericParameterConstraint
    {
        public abstract partial class Class
        {
            public static class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
