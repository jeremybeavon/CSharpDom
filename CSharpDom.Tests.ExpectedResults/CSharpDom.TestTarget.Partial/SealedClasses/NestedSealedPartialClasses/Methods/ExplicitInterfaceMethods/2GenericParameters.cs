namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public sealed class SealedClassWithNestedSealedPartialClassWithExplicitInterfaceMethodWith2GenericParameters
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
