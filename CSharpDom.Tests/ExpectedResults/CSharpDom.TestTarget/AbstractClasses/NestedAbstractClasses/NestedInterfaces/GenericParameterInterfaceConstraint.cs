namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public abstract class Class
        {
            public interface Interface<T>
                where T : IInterface
            {
            }
        }
    }
}
