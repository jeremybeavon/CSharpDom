namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedStaticPartialClassWithNestedStaticPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static partial class Class
        {
            public static class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
