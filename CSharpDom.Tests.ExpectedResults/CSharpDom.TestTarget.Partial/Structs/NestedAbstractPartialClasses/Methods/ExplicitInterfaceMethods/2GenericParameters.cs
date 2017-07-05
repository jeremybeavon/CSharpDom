namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Methods.ExplicitInterfaceMethods
{
    public struct StructWithNestedAbstractPartialClassWithExplicitInterfaceMethodWith2GenericParameters
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
