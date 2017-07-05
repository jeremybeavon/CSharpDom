namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public struct StructWithNestedStructWithExplicitInterfaceMethodWith1Attribute
    {
        public struct Struct : IInterfaceWithMethod
        {
            [Attribute1]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
