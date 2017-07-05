namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public partial class PartialClassWithNestedStructWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups
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
