namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs
{
    public partial struct PartialStructWithWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public struct Struct<T>
            where T : class, IInterface, new()
        {
        }
    }
}
