namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class
        {
            public interface Interface<T>
                where T : new()
            {
            }
        }
    }
}
