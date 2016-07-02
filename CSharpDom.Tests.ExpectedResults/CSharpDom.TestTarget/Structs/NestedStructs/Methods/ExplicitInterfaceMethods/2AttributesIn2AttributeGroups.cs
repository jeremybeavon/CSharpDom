namespace CSharpDom.TestTarget.Structs.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public struct StructWithNestedStructWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups
    {
        public struct Struct : IInterfaceWithMethod
        {
            [Attribute1]
            [Attribute2]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
