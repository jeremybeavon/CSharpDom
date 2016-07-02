namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
