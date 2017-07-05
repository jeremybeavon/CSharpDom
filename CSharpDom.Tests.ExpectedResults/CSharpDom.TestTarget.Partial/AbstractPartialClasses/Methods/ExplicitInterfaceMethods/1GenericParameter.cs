namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Methods.ExplicitInterfaceMethods
{
    public abstract partial class AbstractPartialClassWithExplicitInterfaceMethodWith1GenericParameter : IInterfaceWithMethodWith1GenericParameter
    {
        T IInterfaceWithMethodWith1GenericParameter.Method<T>()
        {
            return default(T);
        }
    }
}
