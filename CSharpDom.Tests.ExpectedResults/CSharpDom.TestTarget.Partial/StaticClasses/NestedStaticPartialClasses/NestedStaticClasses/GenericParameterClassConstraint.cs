namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedStaticPartialClassWithNestedStaticPartialClassWithGenericParameterClassConstraint
    {
        public static partial class Class
        {
            public static class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
