namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public interface Interface<T>
            where T : class, new()
        {
        }
    }
}
