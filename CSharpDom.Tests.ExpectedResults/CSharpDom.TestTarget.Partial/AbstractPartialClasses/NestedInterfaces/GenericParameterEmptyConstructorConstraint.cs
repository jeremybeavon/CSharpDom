namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedInterfaces
{
    public abstract partial class AbstractPartialClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public interface Interface<T>
            where T : new()
        {
        }
    }
}
