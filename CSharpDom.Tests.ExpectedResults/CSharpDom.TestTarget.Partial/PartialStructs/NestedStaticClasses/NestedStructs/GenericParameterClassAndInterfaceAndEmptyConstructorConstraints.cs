namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.NestedStructs
{
    public partial struct PartialStructWithWithNestedStaticClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public struct NestedStruct<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
