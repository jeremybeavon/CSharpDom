namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public class ClassWithNestedStructWithExplicitInterfaceMethodWith2GenericParameters
    {
        public struct Struct : IInterfaceWithMethodWith2GenericParameters
        {
            Dictionary<TKey, TValue> IInterfaceWithMethodWith2GenericParameters.Method<TKey, TValue>()
            {
                return default(Dictionary<TKey, TValue>);
            }
        }
    }
}
