namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public interface Interface<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
