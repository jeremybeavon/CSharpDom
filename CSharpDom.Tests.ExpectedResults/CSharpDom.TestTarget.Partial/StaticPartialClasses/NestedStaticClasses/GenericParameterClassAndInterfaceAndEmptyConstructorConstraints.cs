namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses
{
    public static partial class StaticPartialClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static class Class<T>
            where T : class, IInterface, new()
        {
        }
    }
}
