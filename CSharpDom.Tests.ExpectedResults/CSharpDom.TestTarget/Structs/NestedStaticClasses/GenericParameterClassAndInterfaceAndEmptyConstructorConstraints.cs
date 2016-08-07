namespace CSharpDom.TestTarget.Structs.NestedStaticClasses
{
    public struct StructWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static class Class<T>
            where T : class, IInterface, new()
        {
        }
    }
}
