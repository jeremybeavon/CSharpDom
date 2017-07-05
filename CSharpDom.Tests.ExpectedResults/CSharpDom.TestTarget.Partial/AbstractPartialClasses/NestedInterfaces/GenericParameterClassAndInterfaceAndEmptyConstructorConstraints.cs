namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedInterfaces
{
    public abstract partial class AbstractPartialClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public interface Interface<T>
            where T : class, IInterface, new()
        {
        }
    }
}
