namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.NestedInterfaces
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
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
