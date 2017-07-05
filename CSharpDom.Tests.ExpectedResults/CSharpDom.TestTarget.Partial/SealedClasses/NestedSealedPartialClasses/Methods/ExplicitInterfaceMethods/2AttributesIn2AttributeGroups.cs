namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public sealed class SealedClassWithNestedSealedPartialClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups
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
