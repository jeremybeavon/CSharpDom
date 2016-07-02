namespace CSharpDom.TestTarget.SealedClasses.Methods.ExplicitInterfaceMethods
{
    public sealed class SealedClassWithExplicitInterfaceMethodWith1GenericParameter : IInterfaceWithMethodWith1GenericParameter
    {
        T IInterfaceWithMethodWith1GenericParameter.Method<T>()
        {
            return default(T);
        }
    }
}
