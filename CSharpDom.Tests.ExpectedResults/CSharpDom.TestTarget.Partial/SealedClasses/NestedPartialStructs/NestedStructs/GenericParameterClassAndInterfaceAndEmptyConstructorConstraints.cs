namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedStructs
{
    public sealed class SealedClassWithNestedStructWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public struct NestedStruct<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
