namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedStaticPartialClassWithNestedStaticPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public static partial class Class
        {
            public static class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
