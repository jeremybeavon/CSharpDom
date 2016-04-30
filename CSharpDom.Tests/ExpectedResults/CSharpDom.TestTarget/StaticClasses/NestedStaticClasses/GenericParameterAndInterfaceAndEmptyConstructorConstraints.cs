namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static class Class<T>
            where T : class, IInterface, new()
        {
        }
    }
}
