namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public sealed class SealedClassWithNestedPartialClassWithExplicitInterfaceMethodWith2GenericParameters
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
