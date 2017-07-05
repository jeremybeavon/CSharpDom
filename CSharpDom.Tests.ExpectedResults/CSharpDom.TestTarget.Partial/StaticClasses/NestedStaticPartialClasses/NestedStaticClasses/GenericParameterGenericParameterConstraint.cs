namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedStaticPartialClassWithNestedStaticPartialClassWithGenericParameterGenericParameterConstraint
    {
        public static partial class Class
        {
            public static class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
