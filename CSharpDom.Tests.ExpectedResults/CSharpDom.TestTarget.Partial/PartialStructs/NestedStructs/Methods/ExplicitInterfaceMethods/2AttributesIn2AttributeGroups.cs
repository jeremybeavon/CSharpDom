namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public partial struct PartialStructWithWithNestedStructWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups
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
