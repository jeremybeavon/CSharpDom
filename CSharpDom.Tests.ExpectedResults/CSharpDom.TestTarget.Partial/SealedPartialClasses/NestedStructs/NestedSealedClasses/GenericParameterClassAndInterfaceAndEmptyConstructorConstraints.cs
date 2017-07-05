namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.NestedSealedClasses
{
    public sealed partial class SealedPartialClassWithNestedStructWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public sealed class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
