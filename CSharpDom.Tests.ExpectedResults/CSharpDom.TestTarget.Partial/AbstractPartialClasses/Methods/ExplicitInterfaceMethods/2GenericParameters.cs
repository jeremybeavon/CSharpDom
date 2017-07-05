namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Methods.ExplicitInterfaceMethods
{
    public abstract partial class AbstractPartialClassWithExplicitInterfaceMethodWith2GenericParameters : IInterfaceWithMethodWith2GenericParameters
    {
        Dictionary<TKey, TValue> IInterfaceWithMethodWith2GenericParameters.Method<TKey, TValue>()
        {
            return default(Dictionary<TKey, TValue>);
        }
    }
}
