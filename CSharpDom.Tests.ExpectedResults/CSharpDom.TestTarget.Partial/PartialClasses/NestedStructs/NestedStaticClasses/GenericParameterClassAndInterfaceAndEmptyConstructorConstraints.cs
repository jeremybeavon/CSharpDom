namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.NestedStaticClasses
{
    public partial class PartialClassWithNestedStructWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
