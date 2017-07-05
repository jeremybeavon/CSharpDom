namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses
{
    public static partial class StaticPartialClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class<T>
            where T : new()
        {
        }
    }
}
