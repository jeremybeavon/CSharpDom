namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public partial class PartialClassWithNestedStructWithExplicitInterfaceMethodWith1GenericParameter
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
