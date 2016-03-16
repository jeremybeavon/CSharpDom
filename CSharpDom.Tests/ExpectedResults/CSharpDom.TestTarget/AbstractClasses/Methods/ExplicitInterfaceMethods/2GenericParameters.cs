namespace CSharpDom.TestTarget.AbstractClasses.Methods.ExplicitInterfaceMethods
{
    public abstract class AbstractClassWithExplicitInterfaceMethodWith2GenericParameters : IInterfaceWithMethodWith2GenericParameters
    {
        Dictionary<TKey, TValue> IInterfaceWithMethodWith2GenericParameters.Method<TKey, TValue>()
        {
            return default(Dictionary<TKey, TValue>);
        }
    }
}
