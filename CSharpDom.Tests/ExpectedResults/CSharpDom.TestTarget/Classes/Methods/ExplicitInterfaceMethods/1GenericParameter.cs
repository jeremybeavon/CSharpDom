namespace CSharpDom.TestTarget.Classes.Methods.ExplicitInterfaceMethods
{
    public class ClassWithExplicitInterfaceMethodWith1GenericParameter : IInterfaceWithMethodWith1GenericParameter
    {
        T IInterfaceWithMethodWith1GenericParameter.Method<T>()
        {
            return default(T);
        }
    }
}
