namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Methods.ExplicitInterfaceMethods
{
    public static partial class StaticPartialClassWithNestedSealedClassWithExplicitInterfaceMethodWith2GenericParameters
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
