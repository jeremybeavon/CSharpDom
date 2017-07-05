namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public sealed partial class SealedPartialClassWithNestedStructWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups
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
