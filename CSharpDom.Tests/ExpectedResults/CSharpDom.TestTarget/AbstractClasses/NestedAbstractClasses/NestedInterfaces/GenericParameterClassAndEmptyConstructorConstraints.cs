namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public interface Interface<T>
                where T : class, new()
            {
            }
        }
    }
}
