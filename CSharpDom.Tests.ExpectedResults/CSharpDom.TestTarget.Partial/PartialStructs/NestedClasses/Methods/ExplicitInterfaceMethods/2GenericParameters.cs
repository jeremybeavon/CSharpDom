namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public partial struct PartialStructWithWithNestedClassWithExplicitInterfaceMethodWith2GenericParameters
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
