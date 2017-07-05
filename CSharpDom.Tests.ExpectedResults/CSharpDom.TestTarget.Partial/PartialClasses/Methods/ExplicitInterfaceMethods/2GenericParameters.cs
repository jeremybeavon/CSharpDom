namespace CSharpDom.TestTarget.Partial.PartialClasses.Methods.ExplicitInterfaceMethods
{
    public partial class PartialClassWithExplicitInterfaceMethodWith2GenericParameters : IInterfaceWithMethodWith2GenericParameters
    {
        Dictionary<TKey, TValue> IInterfaceWithMethodWith2GenericParameters.Method<TKey, TValue>()
        {
            return default(Dictionary<TKey, TValue>);
        }
    }
}
