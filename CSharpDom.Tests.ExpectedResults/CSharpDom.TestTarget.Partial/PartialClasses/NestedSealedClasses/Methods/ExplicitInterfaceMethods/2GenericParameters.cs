namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Methods.ExplicitInterfaceMethods
{
    public partial class PartialClassWithNestedSealedClassWithExplicitInterfaceMethodWith2GenericParameters
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
