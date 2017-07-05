namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public sealed partial class SealedPartialClassWithNestedStructWithExplicitInterfaceMethodWith2GenericParameters
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
