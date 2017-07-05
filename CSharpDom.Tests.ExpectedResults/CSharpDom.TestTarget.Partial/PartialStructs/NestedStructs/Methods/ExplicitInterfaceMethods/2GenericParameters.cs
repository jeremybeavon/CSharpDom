namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public partial struct PartialStructWithWithNestedStructWithExplicitInterfaceMethodWith2GenericParameters
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
