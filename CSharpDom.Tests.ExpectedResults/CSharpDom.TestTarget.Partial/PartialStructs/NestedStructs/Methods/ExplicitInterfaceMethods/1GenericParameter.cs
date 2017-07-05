namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public partial struct PartialStructWithWithNestedStructWithExplicitInterfaceMethodWith1GenericParameter
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
