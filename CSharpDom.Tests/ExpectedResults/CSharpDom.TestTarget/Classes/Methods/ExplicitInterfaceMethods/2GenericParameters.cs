namespace CSharpDom.TestTarget.Classes.Methods.ExplicitInterfaceMethods
{
    public class ClassWithExplicitInterfaceMethodWith2GenericParameters : IInterfaceWithMethodWith2GenericParameters
    {
        Dictionary<TKey, TValue> IInterfaceWithMethodWith2GenericParameters.Method<TKey, TValue>()
        {
            return default(Dictionary<TKey, TValue>);
        }
    }
}
