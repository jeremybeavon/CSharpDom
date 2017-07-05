namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedInterfaces
{
    public abstract partial class AbstractPartialClassWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public interface Interface<T>
            where T : struct
        {
        }
    }
}
