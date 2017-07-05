namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedInterfaces
{
    public abstract partial class AbstractPartialClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public interface Interface<T>
            where T : class
        {
        }
    }
}
