namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedInterfaces
{
    public partial class PartialClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public interface Interface<T>
            where T : new()
        {
        }
    }
}
