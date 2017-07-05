namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public interface Interface<T>
            where T : BaseClass
        {
        }
    }
}
