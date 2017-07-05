namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedInterfaces
{
    public abstract partial class AbstractPartialClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public interface Interface<T>
            where T : IInterface
        {
        }
    }
}
