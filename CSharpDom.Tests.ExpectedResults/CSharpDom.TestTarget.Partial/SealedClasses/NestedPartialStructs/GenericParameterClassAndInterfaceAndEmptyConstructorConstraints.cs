namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs
{
    public sealed class SealedClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public struct Struct<T>
            where T : class, IInterface, new()
        {
        }
    }
}
