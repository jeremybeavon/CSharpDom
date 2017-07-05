namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedInterfaces
{
    public partial class PartialClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public interface Interface<T>
            where T : class, new()
        {
        }
    }
}
