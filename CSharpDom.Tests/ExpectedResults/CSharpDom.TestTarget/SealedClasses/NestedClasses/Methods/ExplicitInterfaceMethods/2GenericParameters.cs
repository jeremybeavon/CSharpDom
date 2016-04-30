namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public sealed class SealedClassWithNestedClassWithExplicitInterfaceMethodWith2GenericParameters
    {
        public class Class : IInterfaceWithMethodWith2GenericParameters
        {
            Dictionary<TKey, TValue> IInterfaceWithMethodWith2GenericParameters.Method<TKey, TValue>()
            {
                return default(Dictionary<TKey, TValue>);
            }
        }
    }
}
