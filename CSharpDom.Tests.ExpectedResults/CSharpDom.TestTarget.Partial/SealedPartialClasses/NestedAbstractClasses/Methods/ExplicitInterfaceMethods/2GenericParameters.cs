namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Methods.ExplicitInterfaceMethods
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithExplicitInterfaceMethodWith2GenericParameters
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
