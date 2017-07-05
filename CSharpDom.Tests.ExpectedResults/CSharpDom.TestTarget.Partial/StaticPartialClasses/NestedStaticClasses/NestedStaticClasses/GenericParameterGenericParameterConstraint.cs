namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.NestedStaticClasses
{
    public static partial class StaticPartialClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint
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
