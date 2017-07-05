namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public interface Interface<T>
            where T : new()
        {
        }
    }
}
