namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Methods.ExplicitInterfaceMethods
{
    public partial struct PartialStructWithNestedSealedClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups
    {
        public sealed class Class : IInterfaceWithMethod
        {
            [Attribute1]
            [Attribute2]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
