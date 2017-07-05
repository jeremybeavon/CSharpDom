namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedAbstractPartialClassWithNestedStaticPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract partial class Class
        {
            public static class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
