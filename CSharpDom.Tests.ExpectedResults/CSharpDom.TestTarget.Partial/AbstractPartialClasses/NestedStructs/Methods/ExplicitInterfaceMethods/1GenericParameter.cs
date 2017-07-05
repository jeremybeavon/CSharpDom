namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public abstract partial class AbstractPartialClassWithNestedStructWithExplicitInterfaceMethodWith1GenericParameter
    {
        public struct Struct : IInterfaceWithMethodWith1GenericParameter
        {
            T IInterfaceWithMethodWith1GenericParameter.Method<T>()
            {
                return default(T);
            }
        }
    }
}
