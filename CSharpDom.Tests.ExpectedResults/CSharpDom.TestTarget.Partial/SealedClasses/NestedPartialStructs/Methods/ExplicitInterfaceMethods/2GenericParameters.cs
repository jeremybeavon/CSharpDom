namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public sealed class SealedClassWithNestedStructWithExplicitInterfaceMethodWith2GenericParameters
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
