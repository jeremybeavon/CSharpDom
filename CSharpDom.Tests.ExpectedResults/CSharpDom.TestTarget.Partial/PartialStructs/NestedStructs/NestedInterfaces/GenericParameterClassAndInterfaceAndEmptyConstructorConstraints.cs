namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedInterfaces
{
    public partial struct PartialStructWithWithNestedStructWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public interface Interface<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
