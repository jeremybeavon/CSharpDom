namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Methods.ExplicitInterfaceMethods
{
    public partial struct PartialStructWithWithNestedAbstractClassWithExplicitInterfaceMethodWith2GenericParameters
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
