namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public interface Interface<T>
            where T : class
        {
        }
    }
}
