namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.NestedInterfaces
{
    public partial struct PartialStructWithWithNestedSealedClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public interface Interface<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
