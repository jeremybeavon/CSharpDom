namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.NestedStaticClasses
{
    public static partial class StaticPartialClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public static class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
