namespace CSharpDom.TestTarget.Partial.PartialClasses.Methods.ExplicitInterfaceMethods
{
    public partial class PartialClassWithExplicitInterfaceMethodWith1GenericParameter : IInterfaceWithMethodWith1GenericParameter
    {
        T IInterfaceWithMethodWith1GenericParameter.Method<T>()
        {
            return default(T);
        }
    }
}
