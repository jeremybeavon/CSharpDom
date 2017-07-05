namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.Methods.ExplicitInterfaceMethods
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithExplicitInterfaceMethodWith2GenericParameters
    {
        public abstract class Class : IInterfaceWithMethodWith2GenericParameters
        {
            Dictionary<TKey, TValue> IInterfaceWithMethodWith2GenericParameters.Method<TKey, TValue>()
            {
                return default(Dictionary<TKey, TValue>);
            }
        }
    }
}
