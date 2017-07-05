namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public partial class PartialClassWithNestedClassWithExplicitInterfaceMethodWith2GenericParameters
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
