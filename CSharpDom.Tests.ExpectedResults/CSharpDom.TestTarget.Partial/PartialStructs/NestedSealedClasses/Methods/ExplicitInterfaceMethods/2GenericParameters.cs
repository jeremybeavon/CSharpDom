namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Methods.ExplicitInterfaceMethods
{
    public partial struct PartialStructWithWithNestedSealedClassWithExplicitInterfaceMethodWith2GenericParameters
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
