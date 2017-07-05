namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedInterfaces
{
    public struct StructWithNestedSealedPartialClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed partial class Class
        {
            public interface Interface<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
