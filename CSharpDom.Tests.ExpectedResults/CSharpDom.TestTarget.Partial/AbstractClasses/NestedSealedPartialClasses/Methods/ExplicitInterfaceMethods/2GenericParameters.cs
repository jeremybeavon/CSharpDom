namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithExplicitInterfaceMethodWith2GenericParameters
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
