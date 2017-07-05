namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public interface Interface<T>
            where T : struct
        {
        }
    }
}
