namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public sealed partial class SealedPartialClassWithExplicitInterfaceMethodWith1GenericParameter : IInterfaceWithMethodWith1GenericParameter
    {
        T IInterfaceWithMethodWith1GenericParameter.Method<T>()
        {
            return default(T);
        }
    }
}
