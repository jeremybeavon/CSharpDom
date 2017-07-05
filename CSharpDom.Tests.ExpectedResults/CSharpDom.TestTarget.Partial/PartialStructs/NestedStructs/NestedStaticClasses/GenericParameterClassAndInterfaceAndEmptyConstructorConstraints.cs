namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedStaticClasses
{
    public partial struct PartialStructWithWithNestedStructWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public static class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
