namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedInterfaces
{
    public partial class PartialClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public interface Interface<T>
            where T : class, IInterface, new()
        {
        }
    }
}
