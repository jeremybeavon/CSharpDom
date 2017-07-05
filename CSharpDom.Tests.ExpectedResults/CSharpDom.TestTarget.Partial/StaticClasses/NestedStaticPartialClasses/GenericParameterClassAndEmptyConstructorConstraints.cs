namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedStaticPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class<T>
            where T : class, new()
        {
        }
    }
}
