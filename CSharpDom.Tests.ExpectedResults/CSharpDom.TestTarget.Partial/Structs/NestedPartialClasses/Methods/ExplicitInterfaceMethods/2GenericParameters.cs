namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public struct StructWithNestedPartialClassWithExplicitInterfaceMethodWith2GenericParameters
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
