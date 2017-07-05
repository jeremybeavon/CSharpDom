namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public struct StructWithNestedStructWithExplicitInterfaceMethodWith1GenericParameter
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
