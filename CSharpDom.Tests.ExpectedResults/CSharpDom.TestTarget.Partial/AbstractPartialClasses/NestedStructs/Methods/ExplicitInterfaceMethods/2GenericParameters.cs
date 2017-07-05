namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public abstract partial class AbstractPartialClassWithNestedStructWithExplicitInterfaceMethodWith2GenericParameters
    {
        public struct Struct : IInterfaceWithMethodWith2GenericParameters
        {
            Dictionary<TKey, TValue> IInterfaceWithMethodWith2GenericParameters.Method<TKey, TValue>()
            {
                return default(Dictionary<TKey, TValue>);
            }
        }
    }
}
