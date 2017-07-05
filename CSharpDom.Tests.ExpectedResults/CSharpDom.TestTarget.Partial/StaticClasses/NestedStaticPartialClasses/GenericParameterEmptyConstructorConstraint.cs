namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedStaticPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class<T>
            where T : new()
        {
        }
    }
}
