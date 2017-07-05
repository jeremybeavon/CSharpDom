namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public interface Interface<T>
            where T : IInterface
        {
        }
    }
}
