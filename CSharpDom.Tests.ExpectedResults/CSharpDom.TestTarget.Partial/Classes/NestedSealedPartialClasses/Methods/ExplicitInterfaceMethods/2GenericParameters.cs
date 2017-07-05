namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public class ClassWithNestedSealedPartialClassWithExplicitInterfaceMethodWith2GenericParameters
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
