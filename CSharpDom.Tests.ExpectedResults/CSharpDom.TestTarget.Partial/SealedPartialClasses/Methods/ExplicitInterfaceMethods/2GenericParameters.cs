namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public sealed partial class SealedPartialClassWithExplicitInterfaceMethodWith2GenericParameters : IInterfaceWithMethodWith2GenericParameters
    {
        Dictionary<TKey, TValue> IInterfaceWithMethodWith2GenericParameters.Method<TKey, TValue>()
        {
            return default(Dictionary<TKey, TValue>);
        }
    }
}
