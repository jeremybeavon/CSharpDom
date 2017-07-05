namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public struct StructWithNestedSealedPartialClassWithExplicitInterfaceMethodWith2GenericParameters
    {
        public sealed class Class : IInterfaceWithMethodWith2GenericParameters
        {
            Dictionary<TKey, TValue> IInterfaceWithMethodWith2GenericParameters.Method<TKey, TValue>()
            {
                return default(Dictionary<TKey, TValue>);
            }
        }
    }
}
