namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public interface Interface<T>
            where T : class, IInterface, new()
        {
        }
    }
}
