namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public interface Interface<T>
            where T : class, IInterface, new()
        {
        }
    }
}
