namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Methods.ExplicitInterfaceMethods
{
    public partial class PartialClassWithNestedAbstractClassWithExplicitInterfaceMethodWith2GenericParameters
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
