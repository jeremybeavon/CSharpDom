namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public static class StaticClassWithNestedPartialClassWithExplicitInterfaceMethodWith2GenericParameters
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
