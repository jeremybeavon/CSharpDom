namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public struct StructWithNestedStructWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup
    {
        public struct Struct : IInterfaceWithMethod
        {
            [Attribute1, Attribute2]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
