namespace CSharpDom.TestTarget.Structs.NestedSealedClasses
{
    public struct StructWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed class Class<T>
            where T : class, IInterface, new()
        {
        }
    }
}
