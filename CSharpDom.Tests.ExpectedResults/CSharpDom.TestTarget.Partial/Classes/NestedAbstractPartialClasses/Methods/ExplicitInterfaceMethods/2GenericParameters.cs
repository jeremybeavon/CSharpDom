namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Methods.ExplicitInterfaceMethods
{
    public class ClassWithNestedAbstractPartialClassWithExplicitInterfaceMethodWith2GenericParameters
    {
        public abstract class Class : IInterfaceWithMethodWith2GenericParameters
        {
            Dictionary<TKey, TValue> IInterfaceWithMethodWith2GenericParameters.Method<TKey, TValue>()
            {
                return default(Dictionary<TKey, TValue>);
            }
        }
    }
}
