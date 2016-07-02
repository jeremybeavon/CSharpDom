namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public static class StaticClassWithNestedClassWithExplicitInterfaceMethodWith2GenericParameters
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
