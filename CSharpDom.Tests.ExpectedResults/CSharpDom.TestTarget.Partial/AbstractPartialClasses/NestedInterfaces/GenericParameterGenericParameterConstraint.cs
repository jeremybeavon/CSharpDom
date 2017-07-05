namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedInterfaces
{
    public abstract partial class AbstractPartialClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
    {
        public interface Interface<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
