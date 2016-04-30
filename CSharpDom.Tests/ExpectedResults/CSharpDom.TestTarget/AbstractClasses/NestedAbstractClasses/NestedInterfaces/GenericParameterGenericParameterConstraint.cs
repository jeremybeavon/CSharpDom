namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class
        {
            public interface Interface<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
