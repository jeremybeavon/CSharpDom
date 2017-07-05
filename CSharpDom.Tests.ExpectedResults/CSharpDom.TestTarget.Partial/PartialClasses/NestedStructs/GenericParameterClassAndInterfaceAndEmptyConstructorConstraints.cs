namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs
{
    public partial class PartialClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public struct Struct<T>
            where T : class, IInterface, new()
        {
        }
    }
}
